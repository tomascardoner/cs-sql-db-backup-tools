using CardonerSistemas.Framework.Base;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CSSqlDbBackupTools
{
    public partial class FormRestoreDatabase : Form
    {

        #region Declarations

#pragma warning disable S1144 // Unused private types or members should be removed
#pragma warning disable IDE0051 // Remove unused private members

        private const string CompressApplicationFilename = "7Z.exe";
        private const string CompressApplicationCompressArguments = "a -t7z \"{0}\" \"{1}\" -mx=9";
        private const string CompressApplicationDecompressArguments = "e -aoa \"{0}\" -o\"{1}\"";
        private const string CompressedFileExtension = "7z";

        private const string BackupFileExtension = "bak";

        private const string SqlServerConnectionString = "Data Source={0};Database={1};Connection Timeout={2};User ID={3};Password={4};";
        private const string SqlServerBackupStatement = "BACKUP DATABASE [{0}] TO DISK = {1} WITH COPY_ONLY, NOFORMAT, INIT, NAME = N'{0} - Full Copy-only Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10";
        private const string SqlServerRestoreStatement = "RESTORE DATABASE [{0}] FILE = N'{0}' FROM DISK = N'{1}' WITH  FILE = 1, MOVE N'{0}' TO N'{2}{3}', MOVE N'{0}_log' TO N'{2}{4}', NOUNLOAD, REPLACE, STATS = 10";
        private const string SqlServerMasterDatabaseName = "master";

#pragma warning restore IDE0051 // Remove unused private members
#pragma warning restore S1144 // Unused private types or members should be removed

        #endregion

        public FormRestoreDatabase()
        {
            InitializeComponent();
        }

        private void This_Load(object sender, EventArgs e)
        {
            GroupBoxSqlServerInfo.Visible = false;
            GroupBoxFoldersAndFiles.Visible = false;
            GroupBoxActions.Visible = false;

            ComboBoxSettings.DisplayMember = "Name";

            ListSettings();
        }

        private void ListSettings()
        {

            ComboBoxSettings.Items.Clear();

            foreach (Database database in Program.Settings.Databases)
            {
                if (string.IsNullOrWhiteSpace(database.Name))
                {
                    database.Name = "« Empty name »";
                }
                ComboBoxSettings.Items.Add(database);
            }
            ComboBoxSettings.Enabled = true;
        }

        private void ComboBoxSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSettings.SelectedItem is string)
            {
                return;
            }

            GroupBoxSqlServerInfo.Visible = true;
            GroupBoxFoldersAndFiles.Visible = true;
            GroupBoxActions.Visible = true;

            Database database = (Database)ComboBoxSettings.SelectedItem;
            if (database != null)
            {
                TextBoxSqlServerInstanceName.Text = database.SqlServerInstanceName;
                TextBoxSqlServerLogin.Text = database.SqlServerLogin;
                if (CardonerSistemas.Framework.Cryptography.StringCipher.Decrypt(database.SqlServerPassword, Program.PublicEncryptionPassword, out string decryptedPassword))
                {
                    TextBoxSqlServerPassword.Text = decryptedPassword;
                }
                else
                {
                    TextBoxSqlServerPassword.Text = string.Empty;
                }
                TextBoxSqlServerDatabase.Text = database.SqlServerDatabase;
                TextBoxBackupFolder.Text = database.BackupFolder;
                TextBoxBackupFileName.Text = database.BackupFileName;
                TextBoxCompressedFileName.Text = database.CompressedFileName;
                TextBoxRestoreFolder.Text = database.RestoreFolder;
                TextBoxRestoreDataFileName.Text = database.RestoreDataFileName;
                TextBoxRestoreLogFileName.Text = database.RestoreLogFileName;
            }
        }

        private void ButtonBackupFolder_Click(object sender, EventArgs e)
        {
            // TODO:
        }

        private void ButtonRestoreFolder_Click(object sender, EventArgs e)
        {
            // TODO:
        }

        private void ButtonFindMostRecentBackupFile_Click(object sender, EventArgs e)
        {
            if (TextBoxBackupFolder.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Backup folder not specified.", CardonerSistemas.Framework.Base.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Path.Exists(TextBoxBackupFolder.Text.Trim()))
            {
                MessageBox.Show("Backup folder doesn't exist.", CardonerSistemas.Framework.Base.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (TextBoxBackupFileName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Backup file name not specified.", CardonerSistemas.Framework.Base.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (TextBoxCompressedFileName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Compressed file name not specified.", CardonerSistemas.Framework.Base.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string searchPattern;

            int indexOfFirstSpecialChar = TextBoxCompressedFileName.Text.Trim().IndexOf('{');
            if (indexOfFirstSpecialChar == -1)
            {
                searchPattern = TextBoxCompressedFileName.Text.Trim();
            }
            else
            {
                searchPattern = TextBoxCompressedFileName.Text.Trim()[..indexOfFirstSpecialChar];
                int indexOfExtensionDot = TextBoxCompressedFileName.Text.Trim().LastIndexOf('.');
                if (indexOfExtensionDot > 0)
                {
                    searchPattern += string.Concat("*", TextBoxCompressedFileName.Text.Trim().AsSpan(indexOfExtensionDot));
                }
            }

            FileInfo fileInfo = new DirectoryInfo(TextBoxBackupFolder.Text.Trim()).GetFiles(searchPattern, SearchOption.TopDirectoryOnly).OrderByDescending(fileInfo => fileInfo.LastWriteTime).FirstOrDefault();
            if (fileInfo == null)
            {
                TextBoxMostRecentBackupFileName.Text = string.Empty;
                TextBoxMostRecentBackupFileModifiedDateTime.Text = string.Empty;
            }
            else
            {
                TextBoxMostRecentBackupFileName.Text = fileInfo.Name;
                TextBoxMostRecentBackupFileModifiedDateTime.Text = $"{fileInfo.LastWriteTime.ToShortDateString()} {fileInfo.LastWriteTime.ToShortTimeString()}";
            }
        }

        private void ButtonRestoreDatabase_Click(object sender, EventArgs e)
        {
            if (TextBoxMostRecentBackupFileName.Text == string.Empty)
            {
                MessageBox.Show("You must find the most recente backup file before restore the database.", CardonerSistemas.Framework.Base.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string backupFolderAndCompressedFileName = Path.Combine(TextBoxBackupFolder.Text, TextBoxMostRecentBackupFileName.Text);
            string restoreFolderAndExtractedBackupFileName = Path.Combine(TextBoxRestoreFolder.Text, Path.GetFileNameWithoutExtension(TextBoxMostRecentBackupFileName.Text) + '.' + BackupFileExtension);

            Application.DoEvents();
            this.Cursor = Cursors.WaitCursor;

            // Decompress the backup file
            try
            {
                System.Diagnostics.Process processDecompress = System.Diagnostics.Process.Start(new ProcessStartInfo()
                {
                    FileName = CompressApplicationFilename,
                    Arguments = string.Format(CompressApplicationDecompressArguments, backupFolderAndCompressedFileName, TextBoxRestoreFolder.Text),
                    UseShellExecute = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
                processDecompress.WaitForExit(Program.Settings.ProcessTimeoutMilliseconds);

                if (processDecompress.ExitCode != 0)
                {
                    this.Cursor = Cursors.Default;
                    return;
                }
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, "Error decompressing the compressed backup file.");
                return;
            }

            // Restore the backup file to SQL Server
            try
            {
                // Connect to SQL Server and execute the restore statement
                SqlConnection sqlConnection = new(string.Format(SqlServerConnectionString, TextBoxSqlServerInstanceName.Text.Trim(), SqlServerMasterDatabaseName, Program.Settings.SqlConnectionTimeout, TextBoxSqlServerLogin.Text.Trim(), TextBoxSqlServerPassword.Text.Trim()));
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandTimeout = Program.Settings.SqlConnectionTimeout;
                sqlCommand.CommandText = string.Format(SqlServerRestoreStatement, TextBoxSqlServerDatabase.Text.Trim(), restoreFolderAndExtractedBackupFileName, FileSystem.PathAddDirectorySeparator(TextBoxRestoreFolder.Text), TextBoxRestoreDataFileName.Text.Trim(), TextBoxRestoreLogFileName.Text.Trim());
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                Error.ProcessException(ex, "Error restoring the database backup.");
                return;
            }

            // Delete the decompressed backup file
            try
            {
                File.Delete(restoreFolderAndExtractedBackupFileName);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                Error.ProcessException(ex, "Error deleting backup file.");
                return;
            }

            this.Cursor = Cursors.Default;
            MessageBox.Show("Database has been restored succesfully.", CardonerSistemas.Framework.Base.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
