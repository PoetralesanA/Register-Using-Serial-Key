Public Class formMain

    Private Sub ResetKeyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetKeyToolStripMenuItem.Click
        ResetKeyToolStripMenuItem.Enabled = False
        formReg.CheckNremoveReg()
    End Sub

End Class