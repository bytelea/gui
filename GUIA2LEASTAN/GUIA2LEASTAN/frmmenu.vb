Public Class frmmenu
    Private Sub btnmcq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmcq.Click
        Me.Hide()
        frmmcqquiz.Show()
    End Sub

    Private Sub btncalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculator.Click
        Me.Hide()
        frmcalculator.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhelp.Click
        Me.Hide()
        frmhelp.Show()
    End Sub
End Class