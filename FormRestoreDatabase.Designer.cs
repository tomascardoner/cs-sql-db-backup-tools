namespace CSSqlDbBackupTools
{
    partial class FormRestoreDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBoxSqlServerLogin = new TextBox();
            TextBoxSqlServerInstanceName = new TextBox();
            LabelSqlServerInstanceName = new Label();
            TextBoxRestoreLogFileName = new TextBox();
            LabelRestoreLogFileName = new Label();
            TextBoxRestoreDataFileName = new TextBox();
            LabelRestoreDataFileName = new Label();
            ButtonRestoreFolder = new Button();
            TextBoxRestoreFolder = new TextBox();
            LabelRestoreFolder = new Label();
            GroupBoxActions = new GroupBox();
            ButtonRestoreDatabase = new Button();
            TextBoxMostRecentBackupFileModifiedDateTime = new TextBox();
            TextBoxMostRecentBackupFileName = new TextBox();
            ButtonFindMostRecentBackupFile = new Button();
            TextBoxCompressedFileName = new TextBox();
            LabelCompressedFileName = new Label();
            LabelBackupFileName = new Label();
            ButtonBackupFolder = new Button();
            LabelSqlServerLogin = new Label();
            TextBoxBackupFileName = new TextBox();
            TextBoxBackupFolder = new TextBox();
            TextBoxSqlServerDatabase = new TextBox();
            LabelSqlServerDatabase = new Label();
            TextBoxSqlServerPassword = new TextBox();
            GroupBoxSqlServerInfo = new GroupBox();
            LabelSqlServerPassword = new Label();
            LabelBackupFolder = new Label();
            GroupBoxFoldersAndFiles = new GroupBox();
            ComboBoxSettings = new ComboBox();
            LabelSettings = new Label();
            GroupBoxActions.SuspendLayout();
            GroupBoxSqlServerInfo.SuspendLayout();
            GroupBoxFoldersAndFiles.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxSqlServerLogin
            // 
            TextBoxSqlServerLogin.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxSqlServerLogin.Location = new Point(107, 52);
            TextBoxSqlServerLogin.Margin = new Padding(4, 3, 4, 3);
            TextBoxSqlServerLogin.Name = "TextBoxSqlServerLogin";
            TextBoxSqlServerLogin.Size = new Size(205, 20);
            TextBoxSqlServerLogin.TabIndex = 3;
            // 
            // TextBoxSqlServerInstanceName
            // 
            TextBoxSqlServerInstanceName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxSqlServerInstanceName.Location = new Point(107, 22);
            TextBoxSqlServerInstanceName.Margin = new Padding(4, 3, 4, 3);
            TextBoxSqlServerInstanceName.Name = "TextBoxSqlServerInstanceName";
            TextBoxSqlServerInstanceName.Size = new Size(344, 20);
            TextBoxSqlServerInstanceName.TabIndex = 1;
            // 
            // LabelSqlServerInstanceName
            // 
            LabelSqlServerInstanceName.AutoSize = true;
            LabelSqlServerInstanceName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSqlServerInstanceName.Location = new Point(8, 25);
            LabelSqlServerInstanceName.Margin = new Padding(4, 0, 4, 0);
            LabelSqlServerInstanceName.Name = "LabelSqlServerInstanceName";
            LabelSqlServerInstanceName.Size = new Size(80, 13);
            LabelSqlServerInstanceName.TabIndex = 0;
            LabelSqlServerInstanceName.Text = "Instance name:";
            // 
            // TextBoxRestoreLogFileName
            // 
            TextBoxRestoreLogFileName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxRestoreLogFileName.Location = new Point(142, 172);
            TextBoxRestoreLogFileName.Margin = new Padding(4, 3, 4, 3);
            TextBoxRestoreLogFileName.Name = "TextBoxRestoreLogFileName";
            TextBoxRestoreLogFileName.Size = new Size(308, 20);
            TextBoxRestoreLogFileName.TabIndex = 13;
            // 
            // LabelRestoreLogFileName
            // 
            LabelRestoreLogFileName.AutoSize = true;
            LabelRestoreLogFileName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelRestoreLogFileName.Location = new Point(8, 175);
            LabelRestoreLogFileName.Margin = new Padding(4, 0, 4, 0);
            LabelRestoreLogFileName.Name = "LabelRestoreLogFileName";
            LabelRestoreLogFileName.Size = new Size(110, 13);
            LabelRestoreLogFileName.TabIndex = 12;
            LabelRestoreLogFileName.Text = "Restore Log filename:";
            // 
            // TextBoxRestoreDataFileName
            // 
            TextBoxRestoreDataFileName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxRestoreDataFileName.Location = new Point(142, 142);
            TextBoxRestoreDataFileName.Margin = new Padding(4, 3, 4, 3);
            TextBoxRestoreDataFileName.Name = "TextBoxRestoreDataFileName";
            TextBoxRestoreDataFileName.Size = new Size(308, 20);
            TextBoxRestoreDataFileName.TabIndex = 11;
            // 
            // LabelRestoreDataFileName
            // 
            LabelRestoreDataFileName.AutoSize = true;
            LabelRestoreDataFileName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelRestoreDataFileName.Location = new Point(8, 145);
            LabelRestoreDataFileName.Margin = new Padding(4, 0, 4, 0);
            LabelRestoreDataFileName.Name = "LabelRestoreDataFileName";
            LabelRestoreDataFileName.Size = new Size(115, 13);
            LabelRestoreDataFileName.TabIndex = 10;
            LabelRestoreDataFileName.Text = "Restore Data filename:";
            // 
            // ButtonRestoreFolder
            // 
            ButtonRestoreFolder.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonRestoreFolder.Location = new Point(743, 112);
            ButtonRestoreFolder.Margin = new Padding(4, 3, 4, 3);
            ButtonRestoreFolder.Name = "ButtonRestoreFolder";
            ButtonRestoreFolder.Size = new Size(28, 23);
            ButtonRestoreFolder.TabIndex = 9;
            ButtonRestoreFolder.Text = "...";
            ButtonRestoreFolder.UseVisualStyleBackColor = true;
            ButtonRestoreFolder.Click += ButtonRestoreFolder_Click;
            // 
            // TextBoxRestoreFolder
            // 
            TextBoxRestoreFolder.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxRestoreFolder.Location = new Point(142, 112);
            TextBoxRestoreFolder.Margin = new Padding(4, 3, 4, 3);
            TextBoxRestoreFolder.Name = "TextBoxRestoreFolder";
            TextBoxRestoreFolder.Size = new Size(596, 20);
            TextBoxRestoreFolder.TabIndex = 8;
            // 
            // LabelRestoreFolder
            // 
            LabelRestoreFolder.AutoSize = true;
            LabelRestoreFolder.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelRestoreFolder.Location = new Point(8, 115);
            LabelRestoreFolder.Margin = new Padding(4, 0, 4, 0);
            LabelRestoreFolder.Name = "LabelRestoreFolder";
            LabelRestoreFolder.Size = new Size(76, 13);
            LabelRestoreFolder.TabIndex = 7;
            LabelRestoreFolder.Text = "Restore folder:";
            // 
            // GroupBoxActions
            // 
            GroupBoxActions.Controls.Add(ButtonRestoreDatabase);
            GroupBoxActions.Controls.Add(TextBoxMostRecentBackupFileModifiedDateTime);
            GroupBoxActions.Controls.Add(TextBoxMostRecentBackupFileName);
            GroupBoxActions.Controls.Add(ButtonFindMostRecentBackupFile);
            GroupBoxActions.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBoxActions.Location = new Point(18, 429);
            GroupBoxActions.Margin = new Padding(4, 3, 4, 3);
            GroupBoxActions.Name = "GroupBoxActions";
            GroupBoxActions.Padding = new Padding(4, 3, 4, 3);
            GroupBoxActions.Size = new Size(786, 129);
            GroupBoxActions.TabIndex = 4;
            GroupBoxActions.TabStop = false;
            GroupBoxActions.Text = "Actions:";
            // 
            // ButtonRestoreDatabase
            // 
            ButtonRestoreDatabase.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonRestoreDatabase.Location = new Point(10, 58);
            ButtonRestoreDatabase.Margin = new Padding(4, 3, 4, 3);
            ButtonRestoreDatabase.Name = "ButtonRestoreDatabase";
            ButtonRestoreDatabase.Size = new Size(761, 65);
            ButtonRestoreDatabase.TabIndex = 3;
            ButtonRestoreDatabase.Text = "Restore database";
            ButtonRestoreDatabase.UseVisualStyleBackColor = true;
            ButtonRestoreDatabase.Click += ButtonRestoreDatabase_Click;
            // 
            // TextBoxMostRecentBackupFileModifiedDateTime
            // 
            TextBoxMostRecentBackupFileModifiedDateTime.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxMostRecentBackupFileModifiedDateTime.Location = new Point(545, 25);
            TextBoxMostRecentBackupFileModifiedDateTime.Margin = new Padding(4, 3, 4, 3);
            TextBoxMostRecentBackupFileModifiedDateTime.Name = "TextBoxMostRecentBackupFileModifiedDateTime";
            TextBoxMostRecentBackupFileModifiedDateTime.ReadOnly = true;
            TextBoxMostRecentBackupFileModifiedDateTime.Size = new Size(226, 20);
            TextBoxMostRecentBackupFileModifiedDateTime.TabIndex = 2;
            // 
            // TextBoxMostRecentBackupFileName
            // 
            TextBoxMostRecentBackupFileName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxMostRecentBackupFileName.Location = new Point(229, 25);
            TextBoxMostRecentBackupFileName.Margin = new Padding(4, 3, 4, 3);
            TextBoxMostRecentBackupFileName.Name = "TextBoxMostRecentBackupFileName";
            TextBoxMostRecentBackupFileName.ReadOnly = true;
            TextBoxMostRecentBackupFileName.Size = new Size(308, 20);
            TextBoxMostRecentBackupFileName.TabIndex = 1;
            // 
            // ButtonFindMostRecentBackupFile
            // 
            ButtonFindMostRecentBackupFile.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonFindMostRecentBackupFile.Location = new Point(10, 22);
            ButtonFindMostRecentBackupFile.Margin = new Padding(4, 3, 4, 3);
            ButtonFindMostRecentBackupFile.Name = "ButtonFindMostRecentBackupFile";
            ButtonFindMostRecentBackupFile.Size = new Size(211, 29);
            ButtonFindMostRecentBackupFile.TabIndex = 0;
            ButtonFindMostRecentBackupFile.Text = "Find most recent Backup file -->";
            ButtonFindMostRecentBackupFile.UseVisualStyleBackColor = true;
            ButtonFindMostRecentBackupFile.Click += ButtonFindMostRecentBackupFile_Click;
            // 
            // TextBoxCompressedFileName
            // 
            TextBoxCompressedFileName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxCompressedFileName.Location = new Point(142, 82);
            TextBoxCompressedFileName.Margin = new Padding(4, 3, 4, 3);
            TextBoxCompressedFileName.Name = "TextBoxCompressedFileName";
            TextBoxCompressedFileName.Size = new Size(308, 20);
            TextBoxCompressedFileName.TabIndex = 6;
            // 
            // LabelCompressedFileName
            // 
            LabelCompressedFileName.AutoSize = true;
            LabelCompressedFileName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelCompressedFileName.Location = new Point(8, 85);
            LabelCompressedFileName.Margin = new Padding(4, 0, 4, 0);
            LabelCompressedFileName.Name = "LabelCompressedFileName";
            LabelCompressedFileName.Size = new Size(110, 13);
            LabelCompressedFileName.TabIndex = 5;
            LabelCompressedFileName.Text = "Compressed filename:";
            // 
            // LabelBackupFileName
            // 
            LabelBackupFileName.AutoSize = true;
            LabelBackupFileName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelBackupFileName.Location = new Point(8, 55);
            LabelBackupFileName.Margin = new Padding(4, 0, 4, 0);
            LabelBackupFileName.Name = "LabelBackupFileName";
            LabelBackupFileName.Size = new Size(89, 13);
            LabelBackupFileName.TabIndex = 3;
            LabelBackupFileName.Text = "Backup filename:";
            // 
            // ButtonBackupFolder
            // 
            ButtonBackupFolder.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonBackupFolder.Location = new Point(743, 22);
            ButtonBackupFolder.Margin = new Padding(4, 3, 4, 3);
            ButtonBackupFolder.Name = "ButtonBackupFolder";
            ButtonBackupFolder.Size = new Size(28, 23);
            ButtonBackupFolder.TabIndex = 2;
            ButtonBackupFolder.Text = "...";
            ButtonBackupFolder.UseVisualStyleBackColor = true;
            ButtonBackupFolder.Click += ButtonBackupFolder_Click;
            // 
            // LabelSqlServerLogin
            // 
            LabelSqlServerLogin.AutoSize = true;
            LabelSqlServerLogin.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSqlServerLogin.Location = new Point(8, 55);
            LabelSqlServerLogin.Margin = new Padding(4, 0, 4, 0);
            LabelSqlServerLogin.Name = "LabelSqlServerLogin";
            LabelSqlServerLogin.Size = new Size(36, 13);
            LabelSqlServerLogin.TabIndex = 2;
            LabelSqlServerLogin.Text = "Login:";
            // 
            // TextBoxBackupFileName
            // 
            TextBoxBackupFileName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxBackupFileName.Location = new Point(142, 52);
            TextBoxBackupFileName.Margin = new Padding(4, 3, 4, 3);
            TextBoxBackupFileName.Name = "TextBoxBackupFileName";
            TextBoxBackupFileName.Size = new Size(308, 20);
            TextBoxBackupFileName.TabIndex = 4;
            // 
            // TextBoxBackupFolder
            // 
            TextBoxBackupFolder.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxBackupFolder.Location = new Point(142, 22);
            TextBoxBackupFolder.Margin = new Padding(4, 3, 4, 3);
            TextBoxBackupFolder.Name = "TextBoxBackupFolder";
            TextBoxBackupFolder.Size = new Size(596, 20);
            TextBoxBackupFolder.TabIndex = 1;
            // 
            // TextBoxSqlServerDatabase
            // 
            TextBoxSqlServerDatabase.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxSqlServerDatabase.Location = new Point(107, 112);
            TextBoxSqlServerDatabase.Margin = new Padding(4, 3, 4, 3);
            TextBoxSqlServerDatabase.Name = "TextBoxSqlServerDatabase";
            TextBoxSqlServerDatabase.Size = new Size(205, 20);
            TextBoxSqlServerDatabase.TabIndex = 7;
            // 
            // LabelSqlServerDatabase
            // 
            LabelSqlServerDatabase.AutoSize = true;
            LabelSqlServerDatabase.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSqlServerDatabase.Location = new Point(8, 115);
            LabelSqlServerDatabase.Margin = new Padding(4, 0, 4, 0);
            LabelSqlServerDatabase.Name = "LabelSqlServerDatabase";
            LabelSqlServerDatabase.Size = new Size(56, 13);
            LabelSqlServerDatabase.TabIndex = 6;
            LabelSqlServerDatabase.Text = "Database:";
            // 
            // TextBoxSqlServerPassword
            // 
            TextBoxSqlServerPassword.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxSqlServerPassword.Location = new Point(107, 82);
            TextBoxSqlServerPassword.Margin = new Padding(4, 3, 4, 3);
            TextBoxSqlServerPassword.Name = "TextBoxSqlServerPassword";
            TextBoxSqlServerPassword.Size = new Size(205, 20);
            TextBoxSqlServerPassword.TabIndex = 5;
            TextBoxSqlServerPassword.UseSystemPasswordChar = true;
            // 
            // GroupBoxSqlServerInfo
            // 
            GroupBoxSqlServerInfo.Controls.Add(TextBoxSqlServerDatabase);
            GroupBoxSqlServerInfo.Controls.Add(LabelSqlServerDatabase);
            GroupBoxSqlServerInfo.Controls.Add(TextBoxSqlServerPassword);
            GroupBoxSqlServerInfo.Controls.Add(LabelSqlServerPassword);
            GroupBoxSqlServerInfo.Controls.Add(TextBoxSqlServerLogin);
            GroupBoxSqlServerInfo.Controls.Add(LabelSqlServerLogin);
            GroupBoxSqlServerInfo.Controls.Add(TextBoxSqlServerInstanceName);
            GroupBoxSqlServerInfo.Controls.Add(LabelSqlServerInstanceName);
            GroupBoxSqlServerInfo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBoxSqlServerInfo.Location = new Point(18, 60);
            GroupBoxSqlServerInfo.Margin = new Padding(4, 3, 4, 3);
            GroupBoxSqlServerInfo.Name = "GroupBoxSqlServerInfo";
            GroupBoxSqlServerInfo.Padding = new Padding(4, 3, 4, 3);
            GroupBoxSqlServerInfo.Size = new Size(786, 150);
            GroupBoxSqlServerInfo.TabIndex = 2;
            GroupBoxSqlServerInfo.TabStop = false;
            GroupBoxSqlServerInfo.Text = "MS-SQL Server info:";
            // 
            // LabelSqlServerPassword
            // 
            LabelSqlServerPassword.AutoSize = true;
            LabelSqlServerPassword.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSqlServerPassword.Location = new Point(8, 85);
            LabelSqlServerPassword.Margin = new Padding(4, 0, 4, 0);
            LabelSqlServerPassword.Name = "LabelSqlServerPassword";
            LabelSqlServerPassword.Size = new Size(56, 13);
            LabelSqlServerPassword.TabIndex = 4;
            LabelSqlServerPassword.Text = "Password:";
            // 
            // LabelBackupFolder
            // 
            LabelBackupFolder.AutoSize = true;
            LabelBackupFolder.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelBackupFolder.Location = new Point(8, 25);
            LabelBackupFolder.Margin = new Padding(4, 0, 4, 0);
            LabelBackupFolder.Name = "LabelBackupFolder";
            LabelBackupFolder.Size = new Size(76, 13);
            LabelBackupFolder.TabIndex = 0;
            LabelBackupFolder.Text = "Backup folder:";
            // 
            // GroupBoxFoldersAndFiles
            // 
            GroupBoxFoldersAndFiles.Controls.Add(TextBoxRestoreLogFileName);
            GroupBoxFoldersAndFiles.Controls.Add(LabelRestoreLogFileName);
            GroupBoxFoldersAndFiles.Controls.Add(TextBoxRestoreDataFileName);
            GroupBoxFoldersAndFiles.Controls.Add(LabelRestoreDataFileName);
            GroupBoxFoldersAndFiles.Controls.Add(ButtonRestoreFolder);
            GroupBoxFoldersAndFiles.Controls.Add(TextBoxRestoreFolder);
            GroupBoxFoldersAndFiles.Controls.Add(LabelRestoreFolder);
            GroupBoxFoldersAndFiles.Controls.Add(TextBoxCompressedFileName);
            GroupBoxFoldersAndFiles.Controls.Add(LabelCompressedFileName);
            GroupBoxFoldersAndFiles.Controls.Add(TextBoxBackupFileName);
            GroupBoxFoldersAndFiles.Controls.Add(LabelBackupFileName);
            GroupBoxFoldersAndFiles.Controls.Add(ButtonBackupFolder);
            GroupBoxFoldersAndFiles.Controls.Add(TextBoxBackupFolder);
            GroupBoxFoldersAndFiles.Controls.Add(LabelBackupFolder);
            GroupBoxFoldersAndFiles.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBoxFoldersAndFiles.Location = new Point(18, 217);
            GroupBoxFoldersAndFiles.Margin = new Padding(4, 3, 4, 3);
            GroupBoxFoldersAndFiles.Name = "GroupBoxFoldersAndFiles";
            GroupBoxFoldersAndFiles.Padding = new Padding(4, 3, 4, 3);
            GroupBoxFoldersAndFiles.Size = new Size(786, 205);
            GroupBoxFoldersAndFiles.TabIndex = 3;
            GroupBoxFoldersAndFiles.TabStop = false;
            GroupBoxFoldersAndFiles.Text = "Folders and files:";
            // 
            // ComboBoxSettings
            // 
            ComboBoxSettings.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxSettings.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComboBoxSettings.FormattingEnabled = true;
            ComboBoxSettings.Location = new Point(105, 14);
            ComboBoxSettings.Margin = new Padding(4, 3, 4, 3);
            ComboBoxSettings.Name = "ComboBoxSettings";
            ComboBoxSettings.Size = new Size(698, 24);
            ComboBoxSettings.TabIndex = 1;
            ComboBoxSettings.SelectedIndexChanged += ComboBoxSettings_SelectedIndexChanged;
            // 
            // LabelSettings
            // 
            LabelSettings.AutoSize = true;
            LabelSettings.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelSettings.Location = new Point(13, 17);
            LabelSettings.Margin = new Padding(4, 0, 4, 0);
            LabelSettings.Name = "LabelSettings";
            LabelSettings.Size = new Size(67, 16);
            LabelSettings.TabIndex = 0;
            LabelSettings.Text = "Settings:";
            // 
            // FormRestoreDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 572);
            Controls.Add(GroupBoxActions);
            Controls.Add(GroupBoxSqlServerInfo);
            Controls.Add(GroupBoxFoldersAndFiles);
            Controls.Add(ComboBoxSettings);
            Controls.Add(LabelSettings);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRestoreDatabase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Restore database backup";
            Load += This_Load;
            GroupBoxActions.ResumeLayout(false);
            GroupBoxActions.PerformLayout();
            GroupBoxSqlServerInfo.ResumeLayout(false);
            GroupBoxSqlServerInfo.PerformLayout();
            GroupBoxFoldersAndFiles.ResumeLayout(false);
            GroupBoxFoldersAndFiles.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal TextBox TextBoxSqlServerLogin;
        internal TextBox TextBoxSqlServerInstanceName;
        internal Label LabelSqlServerInstanceName;
        internal TextBox TextBoxRestoreLogFileName;
        internal Label LabelRestoreLogFileName;
        internal TextBox TextBoxRestoreDataFileName;
        internal Label LabelRestoreDataFileName;
        internal Button ButtonRestoreFolder;
        internal TextBox TextBoxRestoreFolder;
        internal Label LabelRestoreFolder;
        internal GroupBox GroupBoxActions;
        internal Button ButtonRestoreDatabase;
        internal TextBox TextBoxMostRecentBackupFileModifiedDateTime;
        internal TextBox TextBoxMostRecentBackupFileName;
        internal Button ButtonFindMostRecentBackupFile;
        internal TextBox TextBoxCompressedFileName;
        internal Label LabelCompressedFileName;
        internal Label LabelBackupFileName;
        internal Button ButtonBackupFolder;
        internal Label LabelSqlServerLogin;
        internal TextBox TextBoxBackupFileName;
        internal TextBox TextBoxBackupFolder;
        internal TextBox TextBoxSqlServerDatabase;
        internal Label LabelSqlServerDatabase;
        internal TextBox TextBoxSqlServerPassword;
        internal GroupBox GroupBoxSqlServerInfo;
        internal Label LabelSqlServerPassword;
        internal Label LabelBackupFolder;
        internal GroupBox GroupBoxFoldersAndFiles;
        internal ComboBox ComboBoxSettings;
        internal Label LabelSettings;
    }
}