Public Class frmlogin

    Private Sub cmbusers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusers.SelectedIndexChanged
        user = cmbusers.Text
        txtpassword.Focus()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        'A command control will validate the selected user. The password for both user is password.
        ' If the username and password are correct the login screen closes and frmquestion1 opens.
        txtpassword.Text = LCase(txtpassword.Text)
        password = txtpassword.Text
        If user = "Admin" And password = "password" Or user = "Guest" And password = "password" Then
            Me.Hide()
            frmmenu.Show()
        End If
        tmrcountdown.Enabled = False
    End Sub

    Private Sub tmrcountdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrcountdown.Tick
        'Include a second timer. Indicate the name, enabled and interval properties of the timer control.
        'Write the code for the timer control procedure. A message box will display an appropriate message
        ' whe the time has run out.
        counter = counter - 1
        lblcountdown.Text = counter & " seconds left!!"
        If counter = 19 Then
            imgEmoji1.Visible = True
        End If
        If counter = 17 Then
            imgEmoji1.Visible = False
            imgEmoji2.Visible = True
        End If
        If counter = 15 Then
            imgEmoji2.Visible = False
            imgEmoji3.Visible = True
        End If
        If counter = 13 Then
            imgEmoji3.Visible = False
            imgEmoji4.Visible = True
        End If
        If counter = 0 Then
            lblcountdown.Text = " Time Up !!!!" & user
            tmrcountdown.Enabled = False
            MsgBox("Incorrect Password " & user)
            End
        End If
    End Sub
    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        counter = "25"
        cmbusers.Items.Add("Admin")
        cmbusers.Items.Add("Guest")
        tmrcountdown.Enabled = True
    End Sub

End Class
