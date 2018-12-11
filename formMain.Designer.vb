<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.buttonBackupDatabase = New System.Windows.Forms.Button()
        Me.buttonRestoreDatabase = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonBackupDatabase
        '
        Me.buttonBackupDatabase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonBackupDatabase.Enabled = False
        Me.buttonBackupDatabase.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.buttonBackupDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonBackupDatabase.Location = New System.Drawing.Point(12, 12)
        Me.buttonBackupDatabase.Name = "buttonBackupDatabase"
        Me.buttonBackupDatabase.Size = New System.Drawing.Size(368, 130)
        Me.buttonBackupDatabase.TabIndex = 0
        Me.buttonBackupDatabase.Text = "Backup Database"
        Me.buttonBackupDatabase.UseVisualStyleBackColor = True
        '
        'buttonRestoreDatabase
        '
        Me.buttonRestoreDatabase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonRestoreDatabase.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.buttonRestoreDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonRestoreDatabase.Location = New System.Drawing.Point(12, 148)
        Me.buttonRestoreDatabase.Name = "buttonRestoreDatabase"
        Me.buttonRestoreDatabase.Size = New System.Drawing.Size(368, 130)
        Me.buttonRestoreDatabase.TabIndex = 1
        Me.buttonRestoreDatabase.Text = "Restore Database"
        Me.buttonRestoreDatabase.UseVisualStyleBackColor = True
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 290)
        Me.Controls.Add(Me.buttonRestoreDatabase)
        Me.Controls.Add(Me.buttonBackupDatabase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CS-SQL DB Backup Tools"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents buttonBackupDatabase As System.Windows.Forms.Button
    Friend WithEvents buttonRestoreDatabase As System.Windows.Forms.Button

End Class
