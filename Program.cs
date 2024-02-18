using System.Text.Json;

namespace CSSqlDbBackupTools
{
    internal static class Program
    {
        internal const string PublicEncryptionPassword = "iRzV|&TUXJYLQ$Hk,b6h~yao38IMmqjl";
        internal static Settings Settings { get; set; } = null;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if (!ReadSettings())
            {
                Application.Exit();
                return;
            }

            Application.Run(new FormMain());
        }

        private static bool ReadSettings()
        {
            string SettingsPathAndFileName = Path.Combine(Application.StartupPath, "Settings.json");
            string jsonSettingsFileString;

            if (!Path.Exists(SettingsPathAndFileName))
            {
                MessageBox.Show("Settings file not found on application folder.", CardonerSistemas.Framework.Base.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                jsonSettingsFileString = File.ReadAllText(SettingsPathAndFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading settings file.\n\nError: {ex.Message}", CardonerSistemas.Framework.Base.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                Settings = JsonSerializer.Deserialize<Settings>(jsonSettingsFileString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deserializing settings file content.\n\nError: {ex.Message}", CardonerSistemas.Framework.Base.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Settings.SqlConnectionTimeout != 0 && Settings.Databases != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}