<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRestoreDatabase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formRestoreDatabase))
        Me.labelSettings = New System.Windows.Forms.Label()
        Me.comboboxSettings = New System.Windows.Forms.ComboBox()
        Me.groupboxFoldersAndFiles = New System.Windows.Forms.GroupBox()
        Me.textboxRestoreLogFileName = New System.Windows.Forms.TextBox()
        Me.labelRestoreLogFileName = New System.Windows.Forms.Label()
        Me.textboxRestoreDataFileName = New System.Windows.Forms.TextBox()
        Me.labelRestoreDataFileName = New System.Windows.Forms.Label()
        Me.buttonRestoreFolder = New System.Windows.Forms.Button()
        Me.textboxRestoreFolder = New System.Windows.Forms.TextBox()
        Me.labelRestoreFolder = New System.Windows.Forms.Label()
        Me.textboxCompressedFileName = New System.Windows.Forms.TextBox()
        Me.labelCompressedFileName = New System.Windows.Forms.Label()
        Me.textboxBackupFileName = New System.Windows.Forms.TextBox()
        Me.labelBackupFileName = New System.Windows.Forms.Label()
        Me.buttonBackupFolder = New System.Windows.Forms.Button()
        Me.textboxBackupFolder = New System.Windows.Forms.TextBox()
        Me.labelBackupFolder = New System.Windows.Forms.Label()
        Me.groupboxSQLServerInfo = New System.Windows.Forms.GroupBox()
        Me.textboxSQLServerDatabase = New System.Windows.Forms.TextBox()
        Me.labelSQLServerDatabase = New System.Windows.Forms.Label()
        Me.textboxSQLServerPassword = New System.Windows.Forms.TextBox()
        Me.labelSQLServerPassword = New System.Windows.Forms.Label()
        Me.textboxSQLServerLogin = New System.Windows.Forms.TextBox()
        Me.labelSQLServerLogin = New System.Windows.Forms.Label()
        Me.textboxSQLServerInstanceName = New System.Windows.Forms.TextBox()
        Me.labelSQLServerInstanceName = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.groupboxActions = New System.Windows.Forms.GroupBox()
        Me.buttonRestoreDatabase = New System.Windows.Forms.Button()
        Me.textboxMostRecentBackupFileModifiedDateTime = New System.Windows.Forms.TextBox()
        Me.textboxMostRecentBackupFileName = New System.Windows.Forms.TextBox()
        Me.buttonFindMostRecentBackupFile = New System.Windows.Forms.Button()
        Me.groupboxFoldersAndFiles.SuspendLayout()
        Me.groupboxSQLServerInfo.SuspendLayout()
        Me.groupboxActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelSettings
        '
        Me.labelSettings.AutoSize = True
        Me.labelSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSettings.Location = New System.Drawing.Point(9, 15)
        Me.labelSettings.Name = "labelSettings"
        Me.labelSettings.Size = New System.Drawing.Size(68, 16)
        Me.labelSettings.TabIndex = 0
        Me.labelSettings.Text = "Settings:"
        '
        'comboboxSettings
        '
        Me.comboboxSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboboxSettings.FormattingEnabled = True
        Me.comboboxSettings.Location = New System.Drawing.Point(87, 12)
        Me.comboboxSettings.Name = "comboboxSettings"
        Me.comboboxSettings.Size = New System.Drawing.Size(599, 24)
        Me.comboboxSettings.TabIndex = 1
        '
        'groupboxFoldersAndFiles
        '
        Me.groupboxFoldersAndFiles.Controls.Add(Me.textboxRestoreLogFileName)
        Me.groupboxFoldersAndFiles.Controls.Add(Me.labelRestoreLogFileName)
        Me.groupboxFoldersAndFiles.Controls.Add(Me.textboxRestoreDataFileName)
        Me.groupboxFoldersAndFiles.Controls.Add(Me.labelRestoreDataFileName)
        Me.groupboxFoldersAndFiles.Controls.Add(Me.buttonRestoreFolder)
        Me.groupboxFoldersAndFiles.Controls.Add(Me.textboxRestoreFolder)
        Me.groupboxFoldersAndFiles.Controls.Add(Me.labelRestoreFolder)
        Me.groupboxFoldersAndFiles.Controls.Add(Me.textboxCompressedFileName)
        Me.groupboxFoldersAndFiles.Controls.Add(Me.labelCompressedFileName)
        Me.groupboxFoldersAndFiles.Controls.Add(Me.textboxBackupFileName)
        Me.groupboxFoldersAndFiles.Controls.Add(Me.labelBackupFileName)
        Me.groupboxFoldersAndFiles.Controls.Add(Me.buttonBackupFolder)
        Me.groupboxFoldersAndFiles.Controls.Add(Me.textboxBackupFolder)
        Me.groupboxFoldersAndFiles.Controls.Add(Me.labelBackupFolder)
        Me.groupboxFoldersAndFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupboxFoldersAndFiles.Location = New System.Drawing.Point(13, 188)
        Me.groupboxFoldersAndFiles.Name = "groupboxFoldersAndFiles"
        Me.groupboxFoldersAndFiles.Size = New System.Drawing.Size(674, 178)
        Me.groupboxFoldersAndFiles.TabIndex = 3
        Me.groupboxFoldersAndFiles.TabStop = False
        Me.groupboxFoldersAndFiles.Text = "Folders and files:"
        '
        'textboxRestoreLogFileName
        '
        Me.textboxRestoreLogFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxRestoreLogFileName.Location = New System.Drawing.Point(122, 149)
        Me.textboxRestoreLogFileName.Name = "textboxRestoreLogFileName"
        Me.textboxRestoreLogFileName.Size = New System.Drawing.Size(265, 20)
        Me.textboxRestoreLogFileName.TabIndex = 13
        '
        'labelRestoreLogFileName
        '
        Me.labelRestoreLogFileName.AutoSize = True
        Me.labelRestoreLogFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRestoreLogFileName.Location = New System.Drawing.Point(6, 152)
        Me.labelRestoreLogFileName.Name = "labelRestoreLogFileName"
        Me.labelRestoreLogFileName.Size = New System.Drawing.Size(110, 13)
        Me.labelRestoreLogFileName.TabIndex = 12
        Me.labelRestoreLogFileName.Text = "Restore Log filename:"
        '
        'textboxRestoreDataFileName
        '
        Me.textboxRestoreDataFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxRestoreDataFileName.Location = New System.Drawing.Point(122, 123)
        Me.textboxRestoreDataFileName.Name = "textboxRestoreDataFileName"
        Me.textboxRestoreDataFileName.Size = New System.Drawing.Size(265, 20)
        Me.textboxRestoreDataFileName.TabIndex = 11
        '
        'labelRestoreDataFileName
        '
        Me.labelRestoreDataFileName.AutoSize = True
        Me.labelRestoreDataFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRestoreDataFileName.Location = New System.Drawing.Point(6, 126)
        Me.labelRestoreDataFileName.Name = "labelRestoreDataFileName"
        Me.labelRestoreDataFileName.Size = New System.Drawing.Size(115, 13)
        Me.labelRestoreDataFileName.TabIndex = 10
        Me.labelRestoreDataFileName.Text = "Restore Data filename:"
        '
        'buttonRestoreFolder
        '
        Me.buttonRestoreFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonRestoreFolder.Location = New System.Drawing.Point(637, 97)
        Me.buttonRestoreFolder.Name = "buttonRestoreFolder"
        Me.buttonRestoreFolder.Size = New System.Drawing.Size(24, 20)
        Me.buttonRestoreFolder.TabIndex = 9
        Me.buttonRestoreFolder.Text = "..."
        Me.buttonRestoreFolder.UseVisualStyleBackColor = True
        '
        'textboxRestoreFolder
        '
        Me.textboxRestoreFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxRestoreFolder.Location = New System.Drawing.Point(122, 97)
        Me.textboxRestoreFolder.Name = "textboxRestoreFolder"
        Me.textboxRestoreFolder.Size = New System.Drawing.Size(511, 20)
        Me.textboxRestoreFolder.TabIndex = 8
        '
        'labelRestoreFolder
        '
        Me.labelRestoreFolder.AutoSize = True
        Me.labelRestoreFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRestoreFolder.Location = New System.Drawing.Point(6, 100)
        Me.labelRestoreFolder.Name = "labelRestoreFolder"
        Me.labelRestoreFolder.Size = New System.Drawing.Size(76, 13)
        Me.labelRestoreFolder.TabIndex = 7
        Me.labelRestoreFolder.Text = "Restore folder:"
        '
        'textboxCompressedFileName
        '
        Me.textboxCompressedFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxCompressedFileName.Location = New System.Drawing.Point(122, 71)
        Me.textboxCompressedFileName.Name = "textboxCompressedFileName"
        Me.textboxCompressedFileName.Size = New System.Drawing.Size(265, 20)
        Me.textboxCompressedFileName.TabIndex = 6
        '
        'labelCompressedFileName
        '
        Me.labelCompressedFileName.AutoSize = True
        Me.labelCompressedFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCompressedFileName.Location = New System.Drawing.Point(6, 74)
        Me.labelCompressedFileName.Name = "labelCompressedFileName"
        Me.labelCompressedFileName.Size = New System.Drawing.Size(110, 13)
        Me.labelCompressedFileName.TabIndex = 5
        Me.labelCompressedFileName.Text = "Compressed filename:"
        '
        'textboxBackupFileName
        '
        Me.textboxBackupFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxBackupFileName.Location = New System.Drawing.Point(122, 45)
        Me.textboxBackupFileName.Name = "textboxBackupFileName"
        Me.textboxBackupFileName.Size = New System.Drawing.Size(265, 20)
        Me.textboxBackupFileName.TabIndex = 4
        '
        'labelBackupFileName
        '
        Me.labelBackupFileName.AutoSize = True
        Me.labelBackupFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBackupFileName.Location = New System.Drawing.Point(6, 48)
        Me.labelBackupFileName.Name = "labelBackupFileName"
        Me.labelBackupFileName.Size = New System.Drawing.Size(89, 13)
        Me.labelBackupFileName.TabIndex = 3
        Me.labelBackupFileName.Text = "Backup filename:"
        '
        'buttonBackupFolder
        '
        Me.buttonBackupFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonBackupFolder.Location = New System.Drawing.Point(637, 19)
        Me.buttonBackupFolder.Name = "buttonBackupFolder"
        Me.buttonBackupFolder.Size = New System.Drawing.Size(24, 20)
        Me.buttonBackupFolder.TabIndex = 2
        Me.buttonBackupFolder.Text = "..."
        Me.buttonBackupFolder.UseVisualStyleBackColor = True
        '
        'textboxBackupFolder
        '
        Me.textboxBackupFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxBackupFolder.Location = New System.Drawing.Point(122, 19)
        Me.textboxBackupFolder.Name = "textboxBackupFolder"
        Me.textboxBackupFolder.Size = New System.Drawing.Size(511, 20)
        Me.textboxBackupFolder.TabIndex = 1
        '
        'labelBackupFolder
        '
        Me.labelBackupFolder.AutoSize = True
        Me.labelBackupFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBackupFolder.Location = New System.Drawing.Point(6, 22)
        Me.labelBackupFolder.Name = "labelBackupFolder"
        Me.labelBackupFolder.Size = New System.Drawing.Size(76, 13)
        Me.labelBackupFolder.TabIndex = 0
        Me.labelBackupFolder.Text = "Backup folder:"
        '
        'groupboxSQLServerInfo
        '
        Me.groupboxSQLServerInfo.Controls.Add(Me.textboxSQLServerDatabase)
        Me.groupboxSQLServerInfo.Controls.Add(Me.labelSQLServerDatabase)
        Me.groupboxSQLServerInfo.Controls.Add(Me.textboxSQLServerPassword)
        Me.groupboxSQLServerInfo.Controls.Add(Me.labelSQLServerPassword)
        Me.groupboxSQLServerInfo.Controls.Add(Me.textboxSQLServerLogin)
        Me.groupboxSQLServerInfo.Controls.Add(Me.labelSQLServerLogin)
        Me.groupboxSQLServerInfo.Controls.Add(Me.textboxSQLServerInstanceName)
        Me.groupboxSQLServerInfo.Controls.Add(Me.labelSQLServerInstanceName)
        Me.groupboxSQLServerInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupboxSQLServerInfo.Location = New System.Drawing.Point(13, 52)
        Me.groupboxSQLServerInfo.Name = "groupboxSQLServerInfo"
        Me.groupboxSQLServerInfo.Size = New System.Drawing.Size(674, 130)
        Me.groupboxSQLServerInfo.TabIndex = 2
        Me.groupboxSQLServerInfo.TabStop = False
        Me.groupboxSQLServerInfo.Text = "MS-SQL Server info:"
        '
        'textboxSQLServerDatabase
        '
        Me.textboxSQLServerDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxSQLServerDatabase.Location = New System.Drawing.Point(92, 97)
        Me.textboxSQLServerDatabase.Name = "textboxSQLServerDatabase"
        Me.textboxSQLServerDatabase.Size = New System.Drawing.Size(176, 20)
        Me.textboxSQLServerDatabase.TabIndex = 7
        '
        'labelSQLServerDatabase
        '
        Me.labelSQLServerDatabase.AutoSize = True
        Me.labelSQLServerDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSQLServerDatabase.Location = New System.Drawing.Point(6, 100)
        Me.labelSQLServerDatabase.Name = "labelSQLServerDatabase"
        Me.labelSQLServerDatabase.Size = New System.Drawing.Size(56, 13)
        Me.labelSQLServerDatabase.TabIndex = 6
        Me.labelSQLServerDatabase.Text = "Database:"
        '
        'textboxSQLServerPassword
        '
        Me.textboxSQLServerPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxSQLServerPassword.Location = New System.Drawing.Point(92, 71)
        Me.textboxSQLServerPassword.Name = "textboxSQLServerPassword"
        Me.textboxSQLServerPassword.Size = New System.Drawing.Size(176, 20)
        Me.textboxSQLServerPassword.TabIndex = 5
        Me.textboxSQLServerPassword.UseSystemPasswordChar = True
        '
        'labelSQLServerPassword
        '
        Me.labelSQLServerPassword.AutoSize = True
        Me.labelSQLServerPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSQLServerPassword.Location = New System.Drawing.Point(6, 74)
        Me.labelSQLServerPassword.Name = "labelSQLServerPassword"
        Me.labelSQLServerPassword.Size = New System.Drawing.Size(56, 13)
        Me.labelSQLServerPassword.TabIndex = 4
        Me.labelSQLServerPassword.Text = "Password:"
        '
        'textboxSQLServerLogin
        '
        Me.textboxSQLServerLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxSQLServerLogin.Location = New System.Drawing.Point(92, 45)
        Me.textboxSQLServerLogin.Name = "textboxSQLServerLogin"
        Me.textboxSQLServerLogin.Size = New System.Drawing.Size(176, 20)
        Me.textboxSQLServerLogin.TabIndex = 3
        '
        'labelSQLServerLogin
        '
        Me.labelSQLServerLogin.AutoSize = True
        Me.labelSQLServerLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSQLServerLogin.Location = New System.Drawing.Point(6, 48)
        Me.labelSQLServerLogin.Name = "labelSQLServerLogin"
        Me.labelSQLServerLogin.Size = New System.Drawing.Size(36, 13)
        Me.labelSQLServerLogin.TabIndex = 2
        Me.labelSQLServerLogin.Text = "Login:"
        '
        'textboxSQLServerInstanceName
        '
        Me.textboxSQLServerInstanceName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxSQLServerInstanceName.Location = New System.Drawing.Point(92, 19)
        Me.textboxSQLServerInstanceName.Name = "textboxSQLServerInstanceName"
        Me.textboxSQLServerInstanceName.Size = New System.Drawing.Size(295, 20)
        Me.textboxSQLServerInstanceName.TabIndex = 1
        '
        'labelSQLServerInstanceName
        '
        Me.labelSQLServerInstanceName.AutoSize = True
        Me.labelSQLServerInstanceName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSQLServerInstanceName.Location = New System.Drawing.Point(6, 22)
        Me.labelSQLServerInstanceName.Name = "labelSQLServerInstanceName"
        Me.labelSQLServerInstanceName.Size = New System.Drawing.Size(80, 13)
        Me.labelSQLServerInstanceName.TabIndex = 0
        Me.labelSQLServerInstanceName.Text = "Instance name:"
        '
        'groupboxActions
        '
        Me.groupboxActions.Controls.Add(Me.buttonRestoreDatabase)
        Me.groupboxActions.Controls.Add(Me.textboxMostRecentBackupFileModifiedDateTime)
        Me.groupboxActions.Controls.Add(Me.textboxMostRecentBackupFileName)
        Me.groupboxActions.Controls.Add(Me.buttonFindMostRecentBackupFile)
        Me.groupboxActions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupboxActions.Location = New System.Drawing.Point(13, 372)
        Me.groupboxActions.Name = "groupboxActions"
        Me.groupboxActions.Size = New System.Drawing.Size(674, 112)
        Me.groupboxActions.TabIndex = 4
        Me.groupboxActions.TabStop = False
        Me.groupboxActions.Text = "Actions:"
        '
        'buttonRestoreDatabase
        '
        Me.buttonRestoreDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonRestoreDatabase.Location = New System.Drawing.Point(9, 50)
        Me.buttonRestoreDatabase.Name = "buttonRestoreDatabase"
        Me.buttonRestoreDatabase.Size = New System.Drawing.Size(652, 56)
        Me.buttonRestoreDatabase.TabIndex = 3
        Me.buttonRestoreDatabase.Text = "Restore database"
        Me.buttonRestoreDatabase.UseVisualStyleBackColor = True
        '
        'textboxMostRecentBackupFileModifiedDateTime
        '
        Me.textboxMostRecentBackupFileModifiedDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxMostRecentBackupFileModifiedDateTime.Location = New System.Drawing.Point(467, 22)
        Me.textboxMostRecentBackupFileModifiedDateTime.Name = "textboxMostRecentBackupFileModifiedDateTime"
        Me.textboxMostRecentBackupFileModifiedDateTime.ReadOnly = True
        Me.textboxMostRecentBackupFileModifiedDateTime.Size = New System.Drawing.Size(194, 20)
        Me.textboxMostRecentBackupFileModifiedDateTime.TabIndex = 2
        '
        'textboxMostRecentBackupFileName
        '
        Me.textboxMostRecentBackupFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxMostRecentBackupFileName.Location = New System.Drawing.Point(196, 22)
        Me.textboxMostRecentBackupFileName.Name = "textboxMostRecentBackupFileName"
        Me.textboxMostRecentBackupFileName.ReadOnly = True
        Me.textboxMostRecentBackupFileName.Size = New System.Drawing.Size(265, 20)
        Me.textboxMostRecentBackupFileName.TabIndex = 1
        '
        'buttonFindMostRecentBackupFile
        '
        Me.buttonFindMostRecentBackupFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonFindMostRecentBackupFile.Location = New System.Drawing.Point(9, 19)
        Me.buttonFindMostRecentBackupFile.Name = "buttonFindMostRecentBackupFile"
        Me.buttonFindMostRecentBackupFile.Size = New System.Drawing.Size(181, 25)
        Me.buttonFindMostRecentBackupFile.TabIndex = 0
        Me.buttonFindMostRecentBackupFile.Text = "Find most recent Backup file -->"
        Me.buttonFindMostRecentBackupFile.UseVisualStyleBackColor = True
        '
        'formRestoreDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 496)
        Me.Controls.Add(Me.groupboxActions)
        Me.Controls.Add(Me.groupboxSQLServerInfo)
        Me.Controls.Add(Me.groupboxFoldersAndFiles)
        Me.Controls.Add(Me.comboboxSettings)
        Me.Controls.Add(Me.labelSettings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formRestoreDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restore database backup file to SQL Server"
        Me.groupboxFoldersAndFiles.ResumeLayout(False)
        Me.groupboxFoldersAndFiles.PerformLayout()
        Me.groupboxSQLServerInfo.ResumeLayout(False)
        Me.groupboxSQLServerInfo.PerformLayout()
        Me.groupboxActions.ResumeLayout(False)
        Me.groupboxActions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelSettings As System.Windows.Forms.Label
    Friend WithEvents comboboxSettings As System.Windows.Forms.ComboBox
    Friend WithEvents groupboxFoldersAndFiles As System.Windows.Forms.GroupBox
    Friend WithEvents buttonBackupFolder As System.Windows.Forms.Button
    Friend WithEvents textboxBackupFolder As System.Windows.Forms.TextBox
    Friend WithEvents labelBackupFolder As System.Windows.Forms.Label
    Friend WithEvents groupboxSQLServerInfo As System.Windows.Forms.GroupBox
    Friend WithEvents textboxSQLServerInstanceName As System.Windows.Forms.TextBox
    Friend WithEvents labelSQLServerInstanceName As System.Windows.Forms.Label
    Friend WithEvents textboxSQLServerLogin As System.Windows.Forms.TextBox
    Friend WithEvents labelSQLServerLogin As System.Windows.Forms.Label
    Friend WithEvents textboxSQLServerPassword As System.Windows.Forms.TextBox
    Friend WithEvents labelSQLServerPassword As System.Windows.Forms.Label
    Friend WithEvents textboxSQLServerDatabase As System.Windows.Forms.TextBox
    Friend WithEvents labelSQLServerDatabase As System.Windows.Forms.Label
    Friend WithEvents textboxBackupFileName As System.Windows.Forms.TextBox
    Friend WithEvents labelBackupFileName As System.Windows.Forms.Label
    Friend WithEvents textboxCompressedFileName As System.Windows.Forms.TextBox
    Friend WithEvents labelCompressedFileName As System.Windows.Forms.Label
    Friend WithEvents textboxRestoreLogFileName As System.Windows.Forms.TextBox
    Friend WithEvents labelRestoreLogFileName As System.Windows.Forms.Label
    Friend WithEvents textboxRestoreDataFileName As System.Windows.Forms.TextBox
    Friend WithEvents labelRestoreDataFileName As System.Windows.Forms.Label
    Friend WithEvents buttonRestoreFolder As System.Windows.Forms.Button
    Friend WithEvents textboxRestoreFolder As System.Windows.Forms.TextBox
    Friend WithEvents labelRestoreFolder As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents groupboxActions As System.Windows.Forms.GroupBox
    Friend WithEvents buttonFindMostRecentBackupFile As System.Windows.Forms.Button
    Friend WithEvents textboxMostRecentBackupFileName As System.Windows.Forms.TextBox
    Friend WithEvents textboxMostRecentBackupFileModifiedDateTime As System.Windows.Forms.TextBox
    Friend WithEvents buttonRestoreDatabase As System.Windows.Forms.Button
End Class
