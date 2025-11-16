Public Class frmmcqquiz2

    Private Sub frmmcqquiz2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Score = 0
        lblcorrectanswer.Text = "Correct answer for test purposes =  " & correct_answer(1)
        lblQ.Text = numbers(1)
        lblQuestion.Text = question(1)
        lblAnsA.Text = answerA(1)
        lblAnsB.Text = answerB(1)
        lblAnsC.Text = answerC(1)
        lblAnsD.Text = answerD(1)
        tmrcountdown.Enabled = True

        txtanswer.Focus()

        counter = 25

    End Sub

    Private Sub cmdnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnext.Click
        accumulator1 = accumulator1 + counter

        frmmcqquiz3.Show()
        tmrcountdown.Enabled = False
        Me.Hide()
        txtanswer.Text = ""
        lblscore.Text = "Your score so far is "
        lblcountdown.Text = "You have 20 seconds to answer each question"

    End Sub

    Private Sub txtanswer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtanswer.TextChanged
        answer_selected = txtanswer.Text
        If (answer_selected = "C") Or (answer_selected = "c") Then
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