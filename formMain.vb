Public Class formMain

    Private Sub RestoreDatabase_Click(sender As Object, e As EventArgs) Handles buttonRestoreDatabase.Click
        Me.Cursor = Cursors.WaitCursor

        formRestoreDatabase.Show()
        Me.Close()

        Me.Cursor = Cursors.Default
    End Sub
End Class
