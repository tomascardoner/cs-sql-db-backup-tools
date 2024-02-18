namespace CSSqlDbBackupTools
{
    public class Database
    {
        public string Name { get; set; }
        public string SqlServerInstanceName { get; set; }
        public string SqlServerLogin { get; set; }
        public string SqlServerPassword { get; set; }
        public string SqlServerDatabase { get; set; }
        public string BackupFolder { get; set; }
        public string BackupFileName { get; set; }
        public string CompressedFileName { get; set; }
        public string RestoreFolder { get; set; }
        public string RestoreDataFileName { get; set; }
        public string RestoreLogFileName { get; set; }
    }

    public class Settings
    {
        public int ProcessTimeoutMilliseconds { get; set; }
        public int SqlConnectionTimeout { get; set; }
        public Database[] Databases { get; set; }
    }
}
