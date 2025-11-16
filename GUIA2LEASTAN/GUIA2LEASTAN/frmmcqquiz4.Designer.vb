<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmcqquiz4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.txt = New System.Windows.Forms.Label
        Me.lblcountdown = New System.Windows.Forms.TextBox
        Me.lblscore = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdnext = New System.Windows.Forms.Button
        Me.lblcorrectanswer = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtanswer = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblAnsD = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblAnsC = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblAnsB = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblAnsA = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblQ = New System.Windows.Forms.TextBox
        Me.lblQuestion = New System.Windows.Forms.TextBox
        Me.lblquestionnum = New System.Windows.Forms.Label
        Me.tmrcountdown = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txt
        '
        Me.txt.AutoSize = True
        Me.txt.BackColor = System.Drawing.Color.Teal
        Me.txt.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(187, 68)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(431, 38)
        Me.txt.TabIndex = 29
        Me.txt.Text = "THIS QUIZ CONSISTS OF QUESTION & FOUR POSSIBLE ANSWERS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "KEY IN YOUR ANSWER BELOW" & _
            " A B C OR D"
        Me.txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcountdown
        '
        Me.lblcountdown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcountdown.Location = New System.Drawing.Point(508, 183)
        Me.lblcountdown.Multiline = True
        Me.lblcountdown.Name = "lblcountdown"
        Me.lblcountdown.Size = New System.Drawing.Size(190, 46)
        Me.lblcountdown.TabIndex = 87
        Me.lblcountdown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.Location = New System.Drawing.Point(616, 411)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(25, 13)
        Me.lblscore.TabIndex = 86
        Me.lblscore.Text = "???"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(538, 409)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Your score is:"
        '
        'cmdnext
        '
        Me.cmdnext.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdnext.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdnext.ForeColor = System.Drawing.Color.Teal
        Me.cmdnext.Location = New System.Drawing.Point(373, 462)
        Me.cmdnext.Name = "cmdnext"
        Me.cmdnext.Size = New System.Drawing.Size(75, 23)
        Me.cmdnext.TabIndex = 84
        Me.cmdnext.Text = "Next"
        Me.cmdnext.UseVisualStyleBackColor = False
        '
        'lblcorrectanswer
        '
        Me.lblcorrectanswer.Location = New System.Drawing.Point(241, 406)
        Me.lblcorrectanswer.Multiline = True
        Me.lblcorrectanswer.Name = "lblcorrectanswer"
        Me.lblcorrectanswer.Size = New System.Drawing.Size(267, 37)
        Me.lblcorrectanswer.TabIndex = 83
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 390)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Correct Answer:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(60, 406)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.Size = New System.Drawing.Size(100, 20)
        Me.txtanswer.TabIndex = 81
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Enter your answer here:"
        '
        'lblAnsD
        '
        Me.lblAnsD.Location = New System.Drawing.Point(128, 333)
        Me.lblAnsD.Name = "lblAnsD"
        Me.lblAnsD.Size = New System.Drawing.Size(320, 20)
        Me.lblAnsD.TabIndex = 79
        Me.lblAnsD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Answer D)"
        '
        'lblAnsC
        '
        Me.lblAnsC.Location = New System.Drawing.Point(128, 284)
        Me.lblAnsC.Name = "lblAnsC"
        Me.lblAnsC.Size = New System.Drawing.Size(320, 20)
        Me.lblAnsC.TabIndex = 77
        Me.lblAnsC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Answer C)"
        '
        'lblAnsB
        '
        Me.lblAnsB.Location = New System.Drawing.Point(128, 233)
        Me.lblAnsB.Name = "lblAnsB"
        Me.lblAnsB.Size = New System.Drawing.Size(320, 20)
        Me.lblAnsB.TabIndex = 75
        Me.lblAnsB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Answer B)"
        '
        'lblAnsA
        '
        Me.lblAnsA.Location = New System.Drawing.Point(128, 187)
        Me.lblAnsA.Name = "lblAnsA"
        Me.lblAnsA.Size = New System.Drawing.Size(320, 20)
        Me.lblAnsA.TabIndex = 73
        Me.lblAnsA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Answer A)"
        '
        'lblQ
        '
        Me.lblQ.Location = New System.Drawing.Point(146, 137)
        Me.lblQ.Name = "lblQ"
        Me.lblQ.Size = New System.Drawing.Size(32, 20)
        Me.lblQ.TabIndex = 71
        '
        'lblQuestion
        '
        Me.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblQuestion.Location = New System.Drawing.Point(218, 137)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(480, 20)
        Me.lblQuestion.TabIndex = 70
        Me.lblQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblquestionnum
        '
        Me.lblquestionnum.AutoSize = True
        Me.lblquestionnum.Location = New System.Drawing.Point(51, 140)
        Me.lblquestionnum.Name = "lblquestionnum"
        Me.lblquestionnum.Size = New System.Drawing.Size(89, 13)
        Me.lblquestionnum.TabIndex = 69
        Me.lblquestionnum.Text = "Question Number"
        '
        'tmrcountdown
        '
        Me.tmrcountdown.Interval = 1000
        '
        'frmmcqquiz4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.lblcountdown)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdnext)
        Me.Controls.Add(Me.lblcorrectanswer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblAnsD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblAnsC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblAnsB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAnsA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblQ)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblquestionnum)
        Me.Controls.Add(Me.txt)
        Me.Name = "frmmcqquiz4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmmcqquiz4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt As System.Windows.Forms.Label
    Friend WithEvents lblcountdown As System.Windows.Forms.TextBox
    Friend WithEvents lblscore As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdnext As System.Windows.Forms.Button
    Friend WithEvents lblcorrectanswer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtanswer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblAnsD As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblAnsC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblAnsB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblAnsA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblQ As System.Windows.Forms.TextBox
    Friend WithEvents lblQuestion As System.Windows.Forms.TextBox
    Friend WithEvents lblquestionnum As System.Windows.Forms.Label
    Friend WithEvents tmrcountdown As System.Windows.Forms.Timer
End Class
