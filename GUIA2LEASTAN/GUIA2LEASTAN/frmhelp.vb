Public Class frmhelp

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        frmmenu.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class