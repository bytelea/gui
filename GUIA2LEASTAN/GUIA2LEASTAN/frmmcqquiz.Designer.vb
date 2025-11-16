<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmcqquiz
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
        Me.lblquestionnum = New System.Windows.Forms.Label
        Me.lblQuestion = New System.Windows.Forms.TextBox
        Me.lblQ = New System.Windows.Forms.TextBox
        Me.lblAnsA = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblAnsB = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblAnsC = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblAnsD = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtanswer = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbl8 = New System.Windows.Forms.Label
        Me.tmrcountdown = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblscore = New System.Windows.Forms.Label
        Me.lblcountdown = New System.Windows.Forms.TextBox
        Me.cmdnext = New System.Windows.Forms.Button
        Me.lblcorrectanswer = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txt
        '
        Me.txt.AutoSize = True
        Me.txt.BackColor = System.Drawing.Color.Teal
        Me.txt.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(204, 59)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(431, 38)
        Me.txt.TabIndex = 12
        Me.txt.Text = "THIS QUIZ CONSISTS OF QUESTION & FOUR POSSIBLE ANSWERS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "KEY IN YOUR ANSWER BELOW" & _
            " A B C OR D"
        Me.txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblquestionnum
        '
        Me.lblquestionnum.AutoSize = True
        Me.lblquestionnum.Location = New System.Drawing.Point(77, 135)
        Me.lblquestionnum.Name = "lblquestionnum"
        Me.lblquestionnum.Size = New System.Drawing.Size(89, 13)
        Me.lblquestionnum.TabIndex = 13
        Me.lblquestionnum.Text = "Question Number"
        '
        'lblQuestion
        '
        Me.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblQuestion.Location = New System.Drawing.Point(231, 132)
        Me.lblQuestion.Multiline = True
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(452, 20)
        Me.lblQuestion.TabIndex = 14
        Me.lblQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQ
        '
        Me.lblQ.Location = New System.Drawing.Point(172, 132)
        Me.lblQ.Name = "lblQ"
        Me.lblQ.Size = New System.Drawing.Size(32, 20)
        Me.lblQ.TabIndex = 15
        '
        'lblAnsA
        '
        Me.lblAnsA.Location = New System.Drawing.Point(153, 185)
        Me.lblAnsA.Name = "lblAnsA"
        Me.lblAnsA.Size = New System.Drawing.Size(316, 20)
        Me.lblAnsA.TabIndex = 17
        Me.lblAnsA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Answer A)"
        '
        'lblAnsB
        '
        Me.lblAnsB.Location = New System.Drawing.Point(153, 228)
        Me.lblAnsB.Name = "lblAnsB"
        Me.lblAnsB.Size = New System.Drawing.Size(316, 20)
        Me.lblAnsB.TabIndex = 19
        Me.lblAnsB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Answer B)"
        '
        'lblAnsC
        '
        Me.lblAnsC.Location = New System.Drawing.Point(153, 279)
        Me.lblAnsC.Name = "lblAnsC"
        Me.lblAnsC.Size = New System.Drawing.Size(316, 20)
        Me.lblAnsC.TabIndex = 21
        Me.lblAnsC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Answer C)"
        '
        'lblAnsD
        '
        Me.lblAnsD.Location = New System.Drawing.Point(153, 328)
        Me.lblAnsD.Name = "lblAnsD"
        Me.lblAnsD.Size = New System.Drawing.Size(316, 20)
        Me.lblAnsD.TabIndex = 23
        Me.lblAnsD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Answer D)"
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(64, 403)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.Size = New System.Drawing.Size(100, 20)
        Me.txtanswer.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 385)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Enter your answer here:"
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.Location = New System.Drawing.Point(241, 385)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(82, 13)
        Me.lbl8.TabIndex = 27
        Me.lbl8.Text = "Correct Answer:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tmrcountdown
        '
        Me.tmrcountdown.Interval = 1000
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(549, 406)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Your score is:"
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.Location = New System.Drawing.Point(627, 408)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(25, 13)
        Me.lblscore.TabIndex = 30
        Me.lblscore.Text = "???"
        '
        'lblcountdown
        '
        Me.lblcountdown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcountdown.Location = New System.Drawing.Point(552, 182)
        Me.lblcountdown.Multiline = True
        Me.lblcountdown.Name = "lblcountdown"
        Me.lblcountdown.Size = New System.Drawing.Size(131, 40)
        Me.lblcountdown.TabIndex = 31
        Me.lblcountdown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdnext
        '
        Me.cmdnext.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdnext.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdnext.ForeColor = System.Drawing.Color.Teal
        Me.cmdnext.Location = New System.Drawing.Point(367, 465)
        Me.cmdnext.Name = "cmdnext"
        Me.cmdnext.Size = New System.Drawing.Size(75, 23)
        Me.cmdnext.TabIndex = 32
        Me.cmdnext.Text = "Next"
        Me.cmdnext.UseVisualStyleBackColor = False
        '
        'lblcorrectanswer
        '
        Me.lblcorrectanswer.Location = New System.Drawing.Point(244, 403)
        Me.lblcorrectanswer.Multiline = True
        Me.lblcorrectanswer.Name = "lblcorrectanswer"
        Me.lblcorrectanswer.Size = New System.Drawing.Size(267, 37)
        Me.lblcorrectanswer.TabIndex = 65
        '
        'frmmcqquiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.lblcorrectanswer)
        Me.Controls.Add(Me.cmdnext)
        Me.Controls.Add(Me.lblcountdown)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl8)
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
        Me.Name = "frmmcqquiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmmcqquiz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt As System.Windows.Forms.Label
    Friend WithEvents lblquestionnum As System.Windows.Forms.Label
    Friend WithEvents lblQuestion As System.Windows.Forms.TextBox
    Friend WithEvents lblQ As System.Windows.Forms.TextBox
    Friend WithEvents lblAnsA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAnsB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblAnsC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblAnsD As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtanswer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl8 As System.Windows.Forms.Label
    Friend WithEvents tmrcountdown As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblscore As System.Windows.Forms.Label
    Friend WithEvents lblcountdown As System.Windows.Forms.TextBox
    Friend WithEvents cmdnext As System.Windows.Forms.Button
    Friend WithEvents lblcorrectanswer As System.Windows.Forms.TextBox
End Class
