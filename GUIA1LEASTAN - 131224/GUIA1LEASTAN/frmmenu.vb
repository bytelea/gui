Public Class frmmenu


    Private Sub frmmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If user = "Admin" Then
            btnrecords.Visible = True
        End If
    End Sub

    Private Sub btnrecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrecords.Click
        Me.Hide()
        frmAddRecords.Show()
    End Sub

    Private Sub btnreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreport.Click
        Me.Hide()
        displaystudentreport.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub
End Class