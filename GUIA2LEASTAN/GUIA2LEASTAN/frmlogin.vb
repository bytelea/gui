Public Class frmlogin
    Dim user_name1 As String
    Dim password1 As String
    Dim user_name2 As String
    Dim password2 As String
    Dim counter As Byte
    Dim user_password As String

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Azure 'this line sets the background colour to azure
        cmbusers.Items.Add("Tester") 'this line adds usernames to the combobox
        cmbusers.Items.Add("Student")
        FileOpen(1, My.Application.Info.DirectoryPath & "\validpassword.DAT", OpenMode.Input)
        Do Until EOF(1)
            Input(1, user_name1)
            Input(1, password1)
            Input(1, user_name2)
            Input(1, password2)
        Loop
        FileClose(1)
    End Sub

    Private Sub CheckBoxrRed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxrRed.CheckedChanged
        Me.BackColor = Color.Red
    End Sub

    Private Sub CheckBoxBlue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxBlue.CheckedChanged
        Me.BackColor = Color.Blue
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        On Error Resume Next
        user_password = txtpassword.Text
        If user = user_name1 And user_password = password1 Or user = user_name2 And user_password = password2 Then
            frmmenu.Show()
        Else : MsgBox("Incorrect username and/or password! Please try again")
        End If
    End Sub

    Private Sub cmbusers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusers.SelectedIndexChanged
        user = cmbusers.Text
        txtpassword.Focus()
    End Sub
End Class