Public Class displaystudentreport
    Dim total_marks As Short
    Dim studentname As String
    Dim Assignment1 As Short
    Dim Assignment2 As Short
    Dim Assignment3 As Short
    Dim Exam As Short
    Dim Allmarks As Short
    Dim grade As String
    Dim cao_points As Integer
    Dim counter As Integer
    Dim student() As String
    Dim bestmark As Integer
    Dim c As Byte
    Dim worst_mark As Integer
    Dim WorstStudent As String
    Dim BestStudent As String
    Dim sum As Single
    Dim average As Single

    Private Sub displaystudentreport(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub cmddisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddisplay.Click
        On Error Resume Next
        worst_mark = 100
        bestmark = 0
        ' Sets the "Results.DAT" as the file to be read from 

        FileOpen(1, My.Application.Info.DirectoryPath & "\results.DAT", OpenMode.Input)
        Do Until EOF(1)
            Input(1, studentname)
            Input(1, Assignment1)
            Input(1, Assignment2)
            Input(1, Assignment3)
            Input(1, Exam)
            Input(1, grade)
            Input(1, cao_points)

            ListBox1.Items.Add(studentname)
            ListBox2.Items.Add(Assignment1)
            ListBox3.Items.Add(Assignment2)
            ListBox4.Items.Add(Assignment3)
            ListBox5.Items.Add(Exam)
            ListBox6.Items.Add(grade)
            ListBox7.Items.Add(cao_points)

            Allmarks = Assignment1 + Assignment2 + Assignment3 + Exam


            lblworstmark.Text = studentname
            sum = sum + Allmarks
            ListBox8.Items.Add(Allmarks)
            ' test for best student 

            If bestmark < Allmarks Then
                bestmark = Allmarks
                BestStudent = studentname
            End If

            If worst_mark > Allmarks Then
                worst_mark = Allmarks
                WorstStudent = studentname
            End If

            c = c + 1 ' COUNT NUMBER OF STUDENTS 

            average = sum / c

            txtbox2.Text = average
        Loop

        txtbeststudent.Text = BestStudent
        txtbestmark1.Text = bestmark
        txtworststudent.Text = WorstStudent
        lblworstmark.Text = worst_mark
        FileClose(1)
    End Sub
    Private Sub btnreturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreturn.Click
        On Error Resume Next
        Me.Hide() ' return to menu 
        frmmenu.Show()
    End Sub
End Class




