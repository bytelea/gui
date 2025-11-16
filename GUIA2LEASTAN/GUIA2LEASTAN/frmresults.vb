Public Class frmresults

    Private Sub frmresults_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblresultstxt.Text = "You got " & Score & " right answers"
        lbltimetaken.Text = "You took " & (60 - accumulator1) & " seconds to complete the quiz !"

        If Score > 4 Then
            lblresultstxt.Text = "Well done " & user & " , you have scored " & Score & " out of " & 10 & vbCrLf & " You are ready to graduate!"
            PicWellDone.Visible = True
        Else
            lbltimetaken.Text = (60 - accumulator1) & " seconds to complete quiz"
            lblresultstxt.Text = "Hard luck " & user & " you have scored " & Score & " out of " & 10 & vbCrLf & " You need to start again"
            PicRestart.Visible = True
        End If

        If PicRestart.Visible = True Then
            btnretry.Show()
        End If
    End Sub

    Private Sub cmdnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnext.Click
        Application.Exit()
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnretry.Click
        Me.Hide()
        frmmcqquiz.Show()
    End Sub
End Class