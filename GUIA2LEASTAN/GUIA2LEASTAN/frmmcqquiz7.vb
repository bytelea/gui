Public Class frmmcqquiz7

    Private Sub frmmcqquiz7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Score = 0
        lblcorrectanswer.Text = "Correct answer for test purposes =  " & correct_answer(6)
        lblQ.Text = numbers(6)
        lblQuestion.Text = question(6)
        lblAnsA.Text = answerA(6)
        lblAnsB.Text = answerB(6)
        lblAnsC.Text = answerC(6)
        lblAnsD.Text = answerD(6)
        tmrcountdown.Enabled = True

        txtanswer.Focus()

        counter = 25

    End Sub

    Private Sub cmdnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnext.Click
        accumulator1 = accumulator1 + counter

        frmmcqquiz8.Show()
        tmrcountdown.Enabled = False
        Me.Hide()
        txtanswer.Text = ""
        lblscore.Text = "Your score so far is "
        lblcountdown.Text = "You have 20 seconds to answer each question"

    End Sub

    Private Sub txtanswer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtanswer.TextChanged
        answer_selected = txtanswer.Text
        If (answer_selected = "A") Or (answer_selected = "a") Then
            Score = Score + 1
            lblscore.Text = "Your score is " & Score
        End If
    End Sub

    Private Sub tmrcountdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrcountdown.Tick
        counter = counter - 1
        lblcountdown.Text = counter & " seconds left!"
        If counter < 6 Then
            lblcountdown.Text = "Hurry up" & user & " " & counter & " seconds left!"
        End If

        If counter = 0 Then
            tmrcountdown.Enabled = False
            Call cmdnext_Click(cmdnext, New System.EventArgs())

        End If

    End Sub

    Private Sub lblcorrectanswer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcorrectanswer.TextChanged
        If user = "Student" Then
            lblcorrectanswer.Visible = False
        End If
        If user = "Student" Then
            Label1.Visible = False
        End If
    End Sub
End Class