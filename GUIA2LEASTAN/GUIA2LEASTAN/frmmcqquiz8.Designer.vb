<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmcqquiz8
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
        Me.lblscore = New System.Windows.Forms.Label
        Me.lblcountdown = New System.Windows.Forms.TextBox
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
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.Location = New System.Drawing.Point(607, 406)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(25, 13)
        Me.lblscore.TabIndex = 163
        Me.lblscore.Text = "???"
        '
        'lblcountdown
        '
        Me.lblcountdown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcountdown.Location = New System.Drawing.Point(500, 180)
        Me.lblcountdown.Multiline = True
        Me.lblcountdown.Name = "lblcountdown"
        Me.lblcountdown.Size = New System.Drawing.Size(190, 48)
        Me.lblcountdown.TabIndex = 162
        Me.lblcountdown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(530, 406)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 161
        Me.Label7.Text = "Your score is:"
        '
        'cmdnext
        '
        Me.cmdnext.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdnext.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdnext.ForeColor = System.Drawing.Color.Teal
        Me.cmdnext.Location = New System.Drawing.Point(365, 459)
        Me.cmdnext.Name = "cmdnext"
        Me.cmdnext.Size = New System.Drawing.Size(75, 23)
        Me.cmdnext.TabIndex = 160
        Me.cmdnext.Text = "Next"
        Me.cmdnext.UseVisualStyleBackColor = False
        '
        'lblcorrectanswer
        '
        Me.lblcorrectanswer.Location = New System.Drawing.Point(233, 403)
        Me.lblcorrectanswer.Multiline = True
        Me.lblcorrectanswer.Name = "lblcorrectanswer"
        Me.lblcorrectanswer.Size = New System.Drawing.Size(267, 37)
        Me.lblcorrectanswer.TabIndex = 159
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "Correct Answer:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(52, 403)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.Size = New System.Drawing.Size(100, 20)
        Me.txtanswer.TabIndex = 157
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 387)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 156
        Me.Label6.Text = "Enter your answer here:"
        '
        'lblAnsD
        '
        Me.lblAnsD.Location = New System.Drawing.Point(120, 330)
        Me.lblAnsD.Name = "lblAnsD"
        Me.lblAnsD.Size = New System.Drawing.Size(345, 20)
        Me.lblAnsD.TabIndex = 155
        Me.lblAnsD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Answer D)"
        '
        'lblAnsC
        '
        Me.lblAnsC.Location = New System.Drawing.Point(120, 281)
        Me.lblAnsC.Name = "lblAnsC"
        Me.lblAnsC.Size = New System.Drawing.Size(345, 20)
        Me.lblAnsC.TabIndex = 153
        Me.lblAnsC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 152
        Me.Label4.Text = "Answer C)"
        '
        'lblAnsB
        '
        Me.lblAnsB.Location = New System.Drawing.Point(120, 230)
        Me.lblAnsB.Multiline = True
        Me.lblAnsB.Name = "lblAnsB"
        Me.lblAnsB.Size = New System.Drawing.Size(345, 36)
        Me.lblAnsB.TabIndex = 151
        Me.lblAnsB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Answer B)"
        '
        'lblAnsA
        '
        Me.lblAnsA.Location = New System.Drawing.Point(120, 184)
        Me.lblAnsA.Name = "lblAnsA"
        Me.lblAnsA.Size = New System.Drawing.Size(345, 20)
        Me.lblAnsA.TabIndex = 149
        Me.lblAnsA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "Answer A)"
        '
        'lblQ
        '
        Me.lblQ.Location = New System.Drawing.Point(138, 134)
        Me.lblQ.Name = "lblQ"
        Me.lblQ.Size = New System.Drawing.Size(32, 20)
        Me.lblQ.TabIndex = 147
        '
        'lblQuestion
        '
        Me.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblQuestion.Location = New System.Drawing.Point(210, 134)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(480, 20)
        Me.lblQuestion.TabIndex = 146
        Me.lblQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblquestionnum
        '
        Me.lblquestionnum.AutoSize = True
        Me.lblquestionnum.Location = New System.Drawing.Point(43, 137)
        Me.lblquestionnum.Name = "lblquestionnum"
        Me.lblquestionnum.Size = New System.Drawing.Size(89, 13)
        Me.lblquestionnum.TabIndex = 145
        Me.lblquestionnum.Text = "Question Number"
        '
        'tmrcountdown
        '
        Me.tmrcountdown.Interval = 1000
        '
        'frmmcqquiz8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.lblcountdown)
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
        Me.Name = "frmmcqquiz8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmmcqquiz8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt As System.Windows.Forms.Label
    Friend WithEvents lblscore As System.Windows.Forms.Label
    Friend WithEvents lblcountdown As System.Windows.Forms.TextBox
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
