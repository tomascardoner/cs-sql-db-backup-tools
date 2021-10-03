Module AppConstants
    Friend Const SETTINGS_FILENAME As String = "settings.ini"

    Friend Const COMPRESS_APPLICATION_7ZIP_FILENAME As String = "7Z.exe"
    Friend Const COMPRESS_APPLICATION_7ZIP_COMPRESS_ARGUMENTS As String = "a -t7z ""{0}"" ""{1}"" -mx=9"
    Friend Const COMPRESS_APPLICATION_7ZIP_DECOMPRESS_ARGUMENTS As String = "e -aoa ""{0}"" -o""{1}"""

    Friend Const SQLSERVER_CONNECTIONSTRING As String = "Data Source={0};Database={1};Connection Timeout={2};User ID={3};Password={4};"
    Friend Const SQLSERVER_BACKUP_STATEMENT As String = "BACKUP DATABASE [{0}] TO DISK = {1} WITH COPY_ONLY, NOFORMAT, INIT, NAME = N'{0} - Full Copy-only Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10"
    Friend Const SQLSERVER_RESTORE_STATEMENT As String = "RESTORE DATABASE [{0}] FILE = N'{0}' FROM DISK = N'{1}' WITH  FILE = 1, MOVE N'{0}' TO N'{2}{3}', MOVE N'{0}_log' TO N'{2}{4}', NOUNLOAD, REPLACE, STATS = 10"
End Module
