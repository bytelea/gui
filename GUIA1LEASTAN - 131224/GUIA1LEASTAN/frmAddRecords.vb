Public Class frmAddRecords
    Dim Student_name As String
    Dim Assignment1 As Integer
    Dim Assignment2 As Integer
    Dim Assignment3 As Integer
    Dim Exam As Integer
    Dim Allmarks As Integer
    Dim Grade As String
    Dim CAO As Integer


    Private Sub frmAddRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
       
    End Sub

    Private Sub BtnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        On Error Resume Next
        Me.Hide()
        frmmenu.Show()
    End Sub

    Private Sub frmAddRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnrecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrecords.Click
        On Error Resume Next

        FileOpen(1, My.Application.Info.DirectoryPath & "\results.dat", OpenMode.Append)
        Student_name = InputBox("Enter Student Name (or click cancel to stop):")
        Do Until Student_name = ""

1:          Assignment1 = InputBox("Enter a mark between 0 and 20 in Assignment 1")
            If Assignment1 < 0 Or Assignment1 > 20 Then
                MsgBox("Invalid mark")
                GoTo 1
            End If

2:          Assignment2 = InputBox("Enter a mark between 1 and 20 in Assignment 2")
            If Assignment2 < 1 Or Assignment2 > 20 Then
                MsgBox("Invalid mark")
                GoTo 2
            End If

3:          Assignment3 = InputBox("Enter a mark between 1 and 30 in Assignment 3")
            If Assignment3 < 1 Or Assignment3 > 30 Then
                MsgBox("Invalid mark")
                GoTo 3
            End If

4:          Exam = InputBox("Enter a mark between 1 and 30 in Exam")
            If Exam < 0 Or Exam > 30 Then
                GoTo 4
            End If

            Allmarks = Assignment1 + Assignment2 + Assignment3 + Exam

            If Allmarks < 50 Then
                Grade = "U"
                CAO = 0
            End If

            If Allmarks >= 50 And Allmarks < 65 Then
                Grade = "P"
                CAO = 16.67
            End If

            If Allmarks >= 65 And Allmarks < 80 Then
                Grade = "M"
                CAO = 33.33
            End If

            If Allmarks >= 80 And Allmarks <= 100 Then
                Grade = "D"
                CAO = 50
            End If

            WriteLine(1, Student_name, Assignment1, Assignment2, Assignment3, Exam, Grade, CAO)
            Student_name = InputBox("Enter new student name or click cancel:")
        Loop
        FileClose(1)
    End Sub
End Class