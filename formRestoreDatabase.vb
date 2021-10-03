Public Class formRestoreDatabase
    Private mSettings As New IniFile

    Private Class SettingsClass
        Public Property ID As String
        Public Property Name As String
    End Class


    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        groupboxSQLServerInfo.Visible = False
        groupboxFoldersAndFiles.Visible = False
        groupboxActions.Visible = False

        comboboxSettings.ValueMember = "ID"
        comboboxSettings.DisplayMember = "Name"

        ListSettings()
    End Sub

    Private Sub ListSettings()
        Dim INIPathAndFileName As String = My.Application.Info.DirectoryPath & "\" & AppConstants.SETTINGS_FILENAME

        comboboxSettings.Items.Clear()

        If My.Computer.FileSystem.FileExists(INIPathAndFileName) Then
            If mSettings.Read(INIPathAndFileName, False) Then
                For Each SectionCurrent As CSSQLDBBackupTools.Section In mSettings.GetSections
                    ' Add new Settings object to combobox
                    Dim SettingsEntry As New SettingsClass

                    SettingsEntry.ID = SectionCurrent.Name  ' Section ID

                    ' Find the Section Name
                    Dim NameKey As CSSQLDBBackupTools.Key
                    NameKey = mSettings.GetKey("Name", SectionCurrent)
                    If Not NameKey Is Nothing AndAlso NameKey.Value.Trim <> "" Then
                        SettingsEntry.Name = NameKey.Value.Trim
                    Else
                        comboboxSettings.Items.Add(SectionCurrent.Name)
                    End If
                    comboboxSettings.Items.Add(SettingsEntry)
                Next
                comboboxSettings.Enabled = True
            Else
                comboboxSettings.Items.Add("Settings file could not be read.")
                comboboxSettings.SelectedIndex = 0
                comboboxSettings.Enabled = False

                groupboxSQLServerInfo.Visible = False
                groupboxFoldersAndFiles.Visible = False
                groupboxActions.Visible = False
            End If
        Else
            comboboxSettings.Items.Add("Settings file not found on app folder.")
            comboboxSettings.SelectedIndex = 0
            comboboxSettings.Enabled = False

            groupboxSQLServerInfo.Visible = False
            groupboxFoldersAndFiles.Visible = False
            groupboxActions.Visible = False
        End If
    End Sub

    Private Sub Settings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxSettings.SelectedIndexChanged
        Dim SettingsCurrent As SettingsClass
        Dim KeyCurrent As CSSQLDBBackupTools.Key

        ' Muestro todos los datos de la Sección
        groupboxSQLServerInfo.Visible = True
        groupboxFoldersAndFiles.Visible = True
        groupboxActions.Visible = True

        SettingsCurrent = CType(comboboxSettings.SelectedItem, SettingsClass)

        ' SQL Server Instance Name
        KeyCurrent = mSettings.GetKey("SQLServerInstanceName", SettingsCurrent.ID)
        If Not KeyCurrent Is Nothing AndAlso KeyCurrent.Value.Trim <> "" Then
            textboxSQLServerInstanceName.Text = KeyCurrent.Value.Trim
        Else
            textboxSQLServerInstanceName.Text = ""
        End If

        ' SQL Server Login
        KeyCurrent = mSettings.GetKey("SQLServerLogin", SettingsCurrent.ID)
        If Not KeyCurrent Is Nothing AndAlso KeyCurrent.Value.Trim <> "" Then
            textboxSQLServerLogin.Text = KeyCurrent.Value.Trim
        Else
            textboxSQLServerLogin.Text = ""
        End If

        ' SQL Server Password
        KeyCurrent = mSettings.GetKey("SQLServerPassword", SettingsCurrent.ID)
        If Not KeyCurrent Is Nothing AndAlso KeyCurrent.Value.Trim <> "" Then
            Dim PasswordDecrypter As New CS_Encrypt_TripleDES(CardonerSistemas.Constants.PublicEncryptionPassword)
            Dim DecryptedPassword As String = ""
            If Not PasswordDecrypter.Decrypt(KeyCurrent.Value.Trim, DecryptedPassword) Then
                textboxSQLServerPassword.Text = ""
            Else
                textboxSQLServerPassword.Text = DecryptedPassword
            End If
            PasswordDecrypter = Nothing
        Else
            textboxSQLServerPassword.Text = ""
        End If

        ' SQL Server Database
        KeyCurrent = mSettings.GetKey("SQLServerDatabase", SettingsCurrent.ID)
        If Not KeyCurrent Is Nothing AndAlso KeyCurrent.Value.Trim <> "" Then
            textboxSQLServerDatabase.Text = KeyCurrent.Value.Trim
        Else
            textboxSQLServerDatabase.Text = ""
        End If

        ' Backup Folder
        KeyCurrent = mSettings.GetKey("BackupFolder", SettingsCurrent.ID)
        If Not KeyCurrent Is Nothing AndAlso KeyCurrent.Value.Trim <> "" Then
            textboxBackupFolder.Text = KeyCurrent.Value.Trim
        Else
            textboxBackupFolder.Text = ""
        End If

        ' Backup FileName
        KeyCurrent = mSettings.GetKey("BackupFileName", SettingsCurrent.ID)
        If Not KeyCurrent Is Nothing AndAlso KeyCurrent.Value.Trim <> "" Then
            textboxBackupFileName.Text = KeyCurrent.Value.Trim
        Else
            textboxBackupFileName.Text = ""
        End If

        ' Compressed FileName
        KeyCurrent = mSettings.GetKey("CompressedFileName", SettingsCurrent.ID)
        If Not KeyCurrent Is Nothing AndAlso KeyCurrent.Value.Trim <> "" Then
            textboxCompressedFileName.Text = KeyCurrent.Value.Trim
        Else
            textboxCompressedFileName.Text = ""
        End If

        ' Restore Folder
        KeyCurrent = mSettings.GetKey("RestoreFolder", SettingsCurrent.ID)
        If Not KeyCurrent Is Nothing AndAlso KeyCurrent.Value.Trim <> "" Then
            textboxRestoreFolder.Text = KeyCurrent.Value.Trim
        Else
            textboxRestoreFolder.Text = ""
        End If

        ' Restore Data FileName
        KeyCurrent = mSettings.GetKey("RestoreDataFileName", SettingsCurrent.ID)
        If Not KeyCurrent Is Nothing AndAlso KeyCurrent.Value.Trim <> "" Then
            textboxRestoreDataFileName.Text = KeyCurrent.Value.Trim
        Else
            textboxRestoreDataFileName.Text = ""
        End If

        ' Restore Log FileName
        KeyCurrent = mSettings.GetKey("RestoreLogFileName", SettingsCurrent.ID)
        If Not KeyCurrent Is Nothing AndAlso KeyCurrent.Value.Trim <> "" Then
            textboxRestoreLogFileName.Text = KeyCurrent.Value.Trim
        Else
            textboxRestoreLogFileName.Text = ""
        End If

        ' Clear the most recent file information
        textboxMostRecentBackupFileName.Text = ""
        textboxMostRecentBackupFileModifiedDateTime.Text = ""
    End Sub

    Private Sub BackupFolder_Click(sender As Object, e As EventArgs) Handles buttonBackupFolder.Click
        If textboxBackupFolder.Text.Trim <> "" Then
            FolderBrowserDialog1.SelectedPath = textboxBackupFolder.Text.Trim
        Else
            FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyDocuments
        End If

        Dim result As DialogResult = FolderBrowserDialog1.ShowDialog(Me)
        If result = Windows.Forms.DialogResult.OK Then
            textboxBackupFolder.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub RestoreFolder_Click(sender As Object, e As EventArgs) Handles buttonRestoreFolder.Click
        If textboxRestoreFolder.Text.Trim <> "" Then
            FolderBrowserDialog1.SelectedPath = textboxRestoreFolder.Text.Trim
        Else
            FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyDocuments
        End If

        Dim result As DialogResult = FolderBrowserDialog1.ShowDialog(Me)
        If result = Windows.Forms.DialogResult.OK Then
            textboxRestoreFolder.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub FindMostRecentBackupFile_Click(sender As Object, e As EventArgs) Handles buttonFindMostRecentBackupFile.Click
        If textboxBackupFolder.Text.Trim = "" Then
            MsgBox("Backup folder is not specified.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxBackupFolder.Focus()
            Exit Sub
        End If
        If Not My.Computer.FileSystem.DirectoryExists(textboxBackupFolder.Text.Trim) Then
            MsgBox("Backup folder specified doesn't exists.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
            textboxBackupFolder.Focus()
            Exit Sub
        End If
        If textboxBackupFileName.Text.Trim = "" Then
            MsgBox("Backup filename is not specified.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxBackupFileName.Focus()
            Exit Sub
        End If
        If textboxCompressedFileName.Text.Trim = "" Then
            MsgBox("Compressed filename is not specified.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxCompressedFileName.Focus()
            Exit Sub
        End If

        ' Construct the Search Pattern
        Dim SearchPattern As String
        Dim IndexOfFirstSpecialChar As Integer
        Dim IndexOfExtensionDot As Integer

        IndexOfFirstSpecialChar = textboxCompressedFileName.Text.Trim.IndexOf("{")
        If IndexOfFirstSpecialChar + 1 = textboxCompressedFileName.Text.Trim.Length Then
            ' Compressed File Name doesn't contains special char
            SearchPattern = textboxCompressedFileName.Text.Trim
        Else
            SearchPattern = textboxCompressedFileName.Text.Trim.Substring(0, IndexOfFirstSpecialChar)
            IndexOfExtensionDot = textboxCompressedFileName.Text.Trim.LastIndexOf(".")
            If IndexOfExtensionDot > 0 Then
                SearchPattern &= "*" & textboxCompressedFileName.Text.Trim.Substring(IndexOfExtensionDot)
            End If
        End If

        Dim di As New IO.DirectoryInfo(textboxBackupFolder.Text.Trim)
        Dim fi As IO.FileInfo

        fi = di.GetFiles(SearchPattern, IO.SearchOption.TopDirectoryOnly).OrderByDescending(Function(f) f.LastWriteTime).FirstOrDefault

        If fi Is Nothing Then
            textboxMostRecentBackupFileName.Text = ""
            textboxMostRecentBackupFileModifiedDateTime.Text = ""
        Else
            textboxMostRecentBackupFileName.Text = fi.Name
            textboxMostRecentBackupFileModifiedDateTime.Text = fi.LastWriteTime.ToShortDateString & " " & fi.LastWriteTime.ToShortTimeString
        End If

    End Sub

    Private Sub RestoreDatabase_Click(sender As Object, e As EventArgs) Handles buttonRestoreDatabase.Click
        If textboxMostRecentBackupFileName.Text = "" Then
            MsgBox("You must find the most recent Backup file before restore the database.", MsgBoxStyle.Information, My.Application.Info.Title)
            buttonFindMostRecentBackupFile.Focus()
            Exit Sub
        End If

        Dim BackupFolderAndCompressedFileName As String
        Dim RestoreFolderAndExtractedBackupFileName As String
        Dim IndexOfExtensionDot As Integer

        ' Get folders and files names
        BackupFolderAndCompressedFileName = textboxBackupFolder.Text.Trim & CStr(IIf(textboxBackupFolder.Text.Trim.Last = "\", "", "\")) & textboxMostRecentBackupFileName.Text
        RestoreFolderAndExtractedBackupFileName = textboxRestoreFolder.Text.Trim & CStr(IIf(textboxRestoreFolder.Text.Trim.Last = "\", "", "\")) & textboxMostRecentBackupFileName.Text
        IndexOfExtensionDot = textboxMostRecentBackupFileName.Text.Trim.LastIndexOf(".")
        If IndexOfExtensionDot > 0 Then
            RestoreFolderAndExtractedBackupFileName = RestoreFolderAndExtractedBackupFileName.Substring(0, IndexOfExtensionDot) & RestoreFolderAndExtractedBackupFileName.Substring(IndexOfExtensionDot).Replace(".7z", ".bak")
        End If

        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()

        ' Decompress the backup file
        Dim psiDecompress As New ProcessStartInfo
        psiDecompress.FileName = COMPRESS_APPLICATION_7ZIP_FILENAME
        psiDecompress.Arguments = String.Format(COMPRESS_APPLICATION_7ZIP_DECOMPRESS_ARGUMENTS, BackupFolderAndCompressedFileName, textboxRestoreFolder.Text)
        psiDecompress.UseShellExecute = True
        psiDecompress.WindowStyle = ProcessWindowStyle.Hidden

        Dim processDecompress As Process = Process.Start(psiDecompress)
        Do While Not processDecompress.HasExited
            Application.DoEvents()
        Loop

        If processDecompress.ExitCode = 0 Then
            Try
                ' Connect to SQL Server and execute the restore statement
                Dim conn As New SqlClient.SqlConnection
                conn.ConnectionString = String.Format(SQLSERVER_CONNECTIONSTRING, textboxSQLServerInstanceName.Text.Trim, "master", My.Settings.SQL_ConnectionTimeout, textboxSQLServerLogin.Text.Trim, textboxSQLServerPassword.Text.Trim)
                conn.Open()
                Dim comm As SqlClient.SqlCommand = conn.CreateCommand
                comm.CommandTimeout = My.Settings.SQL_CommandTimeout
                comm.CommandText = String.Format(SQLSERVER_RESTORE_STATEMENT, textboxSQLServerDatabase.Text.Trim, RestoreFolderAndExtractedBackupFileName, textboxRestoreFolder.Text.Trim & CStr(IIf(textboxRestoreFolder.Text.Trim.Last = "\", "", "\")), textboxRestoreDataFileName.Text.Trim, textboxRestoreLogFileName.Text.Trim)
                comm.CommandType = CommandType.Text
                comm.ExecuteNonQuery()

                ' Delete the decompressed backup file
                My.Computer.FileSystem.DeleteFile(RestoreFolderAndExtractedBackupFileName)
                Me.Cursor = Cursors.Default
                Application.DoEvents()
                MsgBox("Database restored succesfully.", MsgBoxStyle.Information, My.Application.Info.Title)
                Exit Try

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Application.DoEvents()
                MsgBox("Error restoring database." & vbCrLf & vbCrLf & "Error: " & ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
            End Try
        Else
            Me.Cursor = Cursors.Default
            Application.DoEvents()
        End If
    End Sub
End Class