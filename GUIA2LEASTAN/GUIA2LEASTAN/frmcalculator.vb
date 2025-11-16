Public Class frmcalculator

    Dim memplus As Integer
    Dim memrecall As Integer
    Dim sqrt As Integer

    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        On Error Resume Next
        Label1.Text = ""
        ' enter the digit 1 to the right of the 
        ' current contents of the text box 
        txtdisplay.Text = txtdisplay.Text & "1"
    End Sub

    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        On Error Resume Next
        label1.Text = ""
        ' enter the digit 2 to the right of the 
        ' current contents of the text box 
        txtdisplay.Text = txtdisplay.Text & "2"
    End Sub

    Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd3.Click
        On Error Resume Next
        label1.Text = ""
        ' enter the digit 3 to the right of the 
        ' current contents of the text box 
        txtdisplay.Text = txtdisplay.Text & "3"
    End Sub

    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
        On Error Resume Next
        label1.Text = ""
        ' enter the digit 4 to the right of the 
        ' current contents of the text box 
        txtdisplay.Text = txtdisplay.Text & "4"
    End Sub

    Private Sub cmd5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd5.Click
        On Error Resume Next
        label1.Text = ""
        ' enter the digit 5 to the right of the 
        ' current contents of the text box 
        txtdisplay.Text = txtdisplay.Text & "5"
    End Sub

    Private Sub cmd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd6.Click
        On Error Resume Next
        label1.Text = ""
        ' enter the digit 6 to the right of the 
        ' current contents of the text box 
        txtdisplay.Text = txtdisplay.Text & "6"
    End Sub

    Private Sub cmd7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd7.Click
        On Error Resume Next
        label1.Text = ""
        ' enter the digit 7 to the right of the 
        ' current contents of the text box 
        txtdisplay.Text = txtdisplay.Text & "7"
    End Sub

    Private Sub cmd8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd8.Click
        On Error Resume Next
        label1.Text = ""
        ' enter the digit 8 to the right of the 
        ' current contents of the text box 
        txtdisplay.Text = txtdisplay.Text & "8"
    End Sub

    Private Sub cmd9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd9.Click
        On Error Resume Next
        label1.Text = ""
        ' enter the digit 9 to the right of the 
        ' current contents of the text box 
        txtdisplay.Text = txtdisplay.Text & "9"
    End Sub

    Private Sub cmd0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd0.Click
        On Error Resume Next
        label1.Text = ""
        ' enter the digit 0 to the right of the 
        ' current contents of the text box 
        txtdisplay.Text = txtdisplay.Text & "0"
    End Sub

    Private Sub cmddecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddecimal.Click
        On Error Resume Next
        countdecimals = countdecimals + 1
        If countdecimals = 1 Then
            label1.Text = ""
            txtdisplay.Text = txtdisplay.Text & "."
        End If
    End Sub

    Private Sub cmdplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplus.Click
        On Error Resume Next
        countdecimals = 0
        ' move the number from the textbox to the variable 
        number1 = txtdisplay.Text
        ' set the variable aoperator to 1 
        aoperator = 1
        ' Blank out the text box so you can enter the next number 
        txtdisplay.Text = ""
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        On Error Resume Next
        ' clear text box and label 
        txtdisplay.Text = ""
        label1.Text = ""
    End Sub

    Private Sub cmdeq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeq.Click
        On Error Resume Next
        ' This procedure checks which operator has been selected 
        ' +,-,* or / 
        ' calculates and displays the answer in label1
        '  and clears the text box
        number2 = txtdisplay.Text
        If aoperator = 1 Then
            answer = number1 + number2
            txtdisplay.Text = ""
            label1.Text = answer
        End If
        If aoperator = 2 Then
            answer = number1 * number2
            txtdisplay.Text = ""
            label1.Text = answer
        End If
        If aoperator = 3 Then
            answer = number1 / number2
            txtdisplay.Text = ""
            label1.Text = answer
        End If
        If aoperator = 4 Then
            answer = number1 - number2
            txtdisplay.Text = ""
            label1.Text = answer
        End If
    End Sub

    Private Sub cmdtimes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtimes.Click
        countdecimals = 0
        number1 = txtdisplay.Text
        aoperator = 2
        txtdisplay.Text = ""
    End Sub

    Private Sub cmdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmin.Click
        countdecimals = 0
        number1 = txtdisplay.Text
        aoperator = 4
        txtdisplay.Text = ""
    End Sub

    Private Sub cmddiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddiv.Click
        countdecimals = 0
        number1 = txtdisplay.Text
        aoperator = 3
        txtdisplay.Text = ""
    End Sub

    Private Sub cmdmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmp.Click
        On Error Resume Next
        memplus = memplus + answer
        txtdisplay.Text = ""
    End Sub

    Private Sub cmdmr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmr.Click
        On Error Resume Next
        label1.Text = memplus
    End Sub

    Private Sub cmdsqroot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsqroot.Click
        On Error Resume Next
        numbers = txtdisplay.Text
        sqrt = System.Math.Sqrt(numbers)
        Me.label1.Text = sqrt
        txtdisplay.Text = "√" & txtdisplay.Text
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        frmmenu.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class