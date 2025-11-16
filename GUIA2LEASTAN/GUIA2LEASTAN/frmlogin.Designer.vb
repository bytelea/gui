<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Me.txt = New System.Windows.Forms.Label
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.lblpassword = New System.Windows.Forms.Label
        Me.lblcmbusers = New System.Windows.Forms.Label
        Me.cmbusers = New System.Windows.Forms.ComboBox
        Me.CheckBoxrRed = New System.Windows.Forms.CheckBox
        Me.CheckBoxBlue = New System.Windows.Forms.CheckBox
        Me.lblcolour = New System.Windows.Forms.Label
        Me.btnlogin = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txt
        '
        Me.txt.AutoSize = True
        Me.txt.BackColor = System.Drawing.Color.Teal
        Me.txt.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(199, 100)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(303, 19)
        Me.txt.TabIndex = 11
        Me.txt.Text = "SELECT USER NAME AND KEY IN PASSWORD"
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(349, 235)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(121, 22)
        Me.txtpassword.TabIndex = 10
        Me.txtpassword.Text = "password"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblpassword.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.Location = New System.Drawing.Point(227, 236)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(102, 17)
        Me.lblpassword.TabIndex = 9
        Me.lblpassword.Text = "Enter Password"
        '
        'lblcmbusers
        '
        Me.lblcmbusers.AutoSize = True
        Me.lblcmbusers.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblcmbusers.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcmbusers.Location = New System.Drawing.Point(227, 169)
        Me.lblcmbusers.Name = "lblcmbusers"
        Me.lblcmbusers.Size = New System.Drawing.Size(109, 17)
        Me.lblcmbusers.TabIndex = 8
        Me.lblcmbusers.Text = "Select Username"
        '
        'cmbusers
        '
        Me.cmbusers.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbusers.FormattingEnabled = True
        Me.cmbusers.Location = New System.Drawing.Point(349, 166)
        Me.cmbusers.Name = "cmbusers"
        Me.cmbusers.Size = New System.Drawing.Size(121, 24)
        Me.cmbusers.TabIndex = 7
        Me.cmbusers.Text = "Usernames"
        '
        'CheckBoxrRed
        '
        Me.CheckBoxrRed.AutoSize = True
        Me.CheckBoxrRed.Location = New System.Drawing.Point(30, 425)
        Me.CheckBoxrRed.Name = "CheckBoxrRed"
        Me.CheckBoxrRed.Size = New System.Drawing.Size(49, 17)
        Me.CheckBoxrRed.TabIndex = 12
        Me.CheckBoxrRed.Text = "RED"
        Me.CheckBoxrRed.UseVisualStyleBackColor = True
        '
        'CheckBoxBlue
        '
        Me.CheckBoxBlue.AutoSize = True
        Me.CheckBoxBlue.Location = New System.Drawing.Point(30, 457)
        Me.CheckBoxBlue.Name = "CheckBoxBlue"
        Me.CheckBoxBlue.Size = New System.Drawing.Size(54, 17)
        Me.CheckBoxBlue.TabIndex = 13
        Me.CheckBoxBlue.Text = "BLUE"
        Me.CheckBoxBlue.UseVisualStyleBackColor = True
        '
        'lblcolour
        '
        Me.lblcolour.AutoSize = True
        Me.lblcolour.BackColor = System.Drawing.Color.Teal
        Me.lblcolour.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcolour.Location = New System.Drawing.Point(30, 390)
        Me.lblcolour.Name = "lblcolour"
        Me.lblcolour.Size = New System.Drawing.Size(242, 19)
        Me.lblcolour.TabIndex = 14
        Me.lblcolour.Text = "SELECT THE COLOUR OF THE FORM"
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.Teal
        Me.btnlogin.Location = New System.Drawing.Point(296, 286)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(115, 39)
        Me.btnlogin.TabIndex = 15
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.lblcolour)
        Me.Controls.Add(Me.CheckBoxBlue)
        Me.Controls.Add(Me.CheckBoxrRed)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblcmbusers)
        Me.Controls.Add(Me.cmbusers)
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmlogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents lblcmbusers As System.Windows.Forms.Label
    Friend WithEvents cmbusers As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxrRed As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxBlue As System.Windows.Forms.CheckBox
    Friend WithEvents lblcolour As System.Windows.Forms.Label
    Friend WithEvents btnlogin As System.Windows.Forms.Button
End Class
