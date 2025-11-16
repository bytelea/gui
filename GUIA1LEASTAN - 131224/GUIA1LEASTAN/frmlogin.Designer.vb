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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.cmbusers = New System.Windows.Forms.ComboBox
        Me.lblcmbusers = New System.Windows.Forms.Label
        Me.lblpassword = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.btnlogin = New System.Windows.Forms.Button
        Me.txt = New System.Windows.Forms.Label
        Me.tmrcountdown = New System.Windows.Forms.Timer(Me.components)
        Me.lblcountdown = New System.Windows.Forms.Label
        Me.imgEmoji2 = New System.Windows.Forms.PictureBox
        Me.imgEmoji3 = New System.Windows.Forms.PictureBox
        Me.imgEmoji4 = New System.Windows.Forms.PictureBox
        Me.imgEmoji1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEmoji2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEmoji3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEmoji4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEmoji1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbusers
        '
        Me.cmbusers.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbusers.FormattingEnabled = True
        Me.cmbusers.Location = New System.Drawing.Point(355, 183)
        Me.cmbusers.Name = "cmbusers"
        Me.cmbusers.Size = New System.Drawing.Size(121, 24)
        Me.cmbusers.TabIndex = 0
        Me.cmbusers.Text = "Usernames"
        '
        'lblcmbusers
        '
        Me.lblcmbusers.AutoSize = True
        Me.lblcmbusers.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblcmbusers.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcmbusers.Location = New System.Drawing.Point(233, 186)
        Me.lblcmbusers.Name = "lblcmbusers"
        Me.lblcmbusers.Size = New System.Drawing.Size(109, 17)
        Me.lblcmbusers.TabIndex = 1
        Me.lblcmbusers.Text = "Select Username"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblpassword.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.Location = New System.Drawing.Point(233, 253)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(102, 17)
        Me.lblpassword.TabIndex = 2
        Me.lblpassword.Text = "Enter Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(508, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(355, 252)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(121, 22)
        Me.txtpassword.TabIndex = 4
        Me.txtpassword.Text = "password"
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.Teal
        Me.btnlogin.Location = New System.Drawing.Point(302, 405)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(115, 39)
        Me.btnlogin.TabIndex = 5
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'txt
        '
        Me.txt.AutoSize = True
        Me.txt.BackColor = System.Drawing.Color.Teal
        Me.txt.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(199, 56)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(303, 19)
        Me.txt.TabIndex = 6
        Me.txt.Text = "SELECT USER NAME AND KEY IN PASSWORD"
        '
        'tmrcountdown
        '
        Me.tmrcountdown.Interval = 1000
        '
        'lblcountdown
        '
        Me.lblcountdown.AutoSize = True
        Me.lblcountdown.Location = New System.Drawing.Point(87, 468)
        Me.lblcountdown.Name = "lblcountdown"
        Me.lblcountdown.Size = New System.Drawing.Size(31, 13)
        Me.lblcountdown.TabIndex = 8
        Me.lblcountdown.Text = "tmrlbl"
        '
        'imgEmoji2
        '
        Me.imgEmoji2.Image = CType(resources.GetObject("imgEmoji2.Image"), System.Drawing.Image)
        Me.imgEmoji2.Location = New System.Drawing.Point(552, 183)
        Me.imgEmoji2.Name = "imgEmoji2"
        Me.imgEmoji2.Size = New System.Drawing.Size(116, 115)
        Me.imgEmoji2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgEmoji2.TabIndex = 9
        Me.imgEmoji2.TabStop = False
        '
        'imgEmoji3
        '
        Me.imgEmoji3.Image = CType(resources.GetObject("imgEmoji3.Image"), System.Drawing.Image)
        Me.imgEmoji3.Location = New System.Drawing.Point(552, 329)
        Me.imgEmoji3.Name = "imgEmoji3"
        Me.imgEmoji3.Size = New System.Drawing.Size(116, 115)
        Me.imgEmoji3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgEmoji3.TabIndex = 10
        Me.imgEmoji3.TabStop = False
        '
        'imgEmoji4
        '
        Me.imgEmoji4.Image = CType(resources.GetObject("imgEmoji4.Image"), System.Drawing.Image)
        Me.imgEmoji4.Location = New System.Drawing.Point(53, 329)
        Me.imgEmoji4.Name = "imgEmoji4"
        Me.imgEmoji4.Size = New System.Drawing.Size(116, 115)
        Me.imgEmoji4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgEmoji4.TabIndex = 11
        Me.imgEmoji4.TabStop = False
        '
        'imgEmoji1
        '
        Me.imgEmoji1.Image = CType(resources.GetObject("imgEmoji1.Image"), System.Drawing.Image)
        Me.imgEmoji1.Location = New System.Drawing.Point(53, 183)
        Me.imgEmoji1.Name = "imgEmoji1"
        Me.imgEmoji1.Size = New System.Drawing.Size(116, 115)
        Me.imgEmoji1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgEmoji1.TabIndex = 12
        Me.imgEmoji1.TabStop = False
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.imgEmoji1)
        Me.Controls.Add(Me.imgEmoji4)
        Me.Controls.Add(Me.imgEmoji3)
        Me.Controls.Add(Me.imgEmoji2)
        Me.Controls.Add(Me.lblcountdown)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblcmbusers)
        Me.Controls.Add(Me.cmbusers)
        Me.Name = "frmlogin"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEmoji2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEmoji3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEmoji4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEmoji1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbusers As System.Windows.Forms.ComboBox
    Friend WithEvents lblcmbusers As System.Windows.Forms.Label
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents txt As System.Windows.Forms.Label
    Friend WithEvents tmrcountdown As System.Windows.Forms.Timer
    Friend WithEvents lblcountdown As System.Windows.Forms.Label
    Friend WithEvents imgEmoji2 As System.Windows.Forms.PictureBox
    Friend WithEvents imgEmoji3 As System.Windows.Forms.PictureBox
    Friend WithEvents imgEmoji4 As System.Windows.Forms.PictureBox
    Friend WithEvents imgEmoji1 As System.Windows.Forms.PictureBox

End Class
