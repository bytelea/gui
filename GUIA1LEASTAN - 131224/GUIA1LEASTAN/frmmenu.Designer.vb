<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmenu))
        Me.img1 = New System.Windows.Forms.PictureBox
        Me.img2 = New System.Windows.Forms.PictureBox
        Me.lblmain = New System.Windows.Forms.Label
        Me.lblsub = New System.Windows.Forms.Label
        Me.btnrecords = New System.Windows.Forms.Button
        Me.btnreport = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        CType(Me.img1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img1
        '
        Me.img1.Image = CType(resources.GetObject("img1.Image"), System.Drawing.Image)
        Me.img1.Location = New System.Drawing.Point(12, 12)
        Me.img1.Name = "img1"
        Me.img1.Size = New System.Drawing.Size(214, 120)
        Me.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.img1.TabIndex = 0
        Me.img1.TabStop = False
        '
        'img2
        '
        Me.img2.Image = CType(resources.GetObject("img2.Image"), System.Drawing.Image)
        Me.img2.Location = New System.Drawing.Point(508, 12)
        Me.img2.Name = "img2"
        Me.img2.Size = New System.Drawing.Size(214, 120)
        Me.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img2.TabIndex = 1
        Me.img2.TabStop = False
        '
        'lblmain
        '
        Me.lblmain.BackColor = System.Drawing.Color.Teal
        Me.lblmain.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmain.Location = New System.Drawing.Point(264, 12)
        Me.lblmain.Name = "lblmain"
        Me.lblmain.Size = New System.Drawing.Size(208, 46)
        Me.lblmain.TabIndex = 7
        Me.lblmain.Text = "STUDENT RECORD MANAGEMENT SYSTEM"
        Me.lblmain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsub
        '
        Me.lblsub.BackColor = System.Drawing.Color.CadetBlue
        Me.lblsub.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsub.Location = New System.Drawing.Point(264, 67)
        Me.lblsub.Name = "lblsub"
        Me.lblsub.Size = New System.Drawing.Size(208, 65)
        Me.lblsub.TabIndex = 8
        Me.lblsub.Text = "Administrator users may add or view records. Guest users may only view records."
        Me.lblsub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnrecords
        '
        Me.btnrecords.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnrecords.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrecords.ForeColor = System.Drawing.Color.Teal
        Me.btnrecords.Location = New System.Drawing.Point(310, 206)
        Me.btnrecords.Name = "btnrecords"
        Me.btnrecords.Size = New System.Drawing.Size(115, 58)
        Me.btnrecords.TabIndex = 9
        Me.btnrecords.Text = "Add Student Records"
        Me.btnrecords.UseVisualStyleBackColor = False
        Me.btnrecords.Visible = False
        '
        'btnreport
        '
        Me.btnreport.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnreport.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.ForeColor = System.Drawing.Color.Teal
        Me.btnreport.Location = New System.Drawing.Point(310, 270)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(115, 55)
        Me.btnreport.TabIndex = 10
        Me.btnreport.Text = "Display Student Results"
        Me.btnreport.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Teal
        Me.btnClose.Location = New System.Drawing.Point(310, 331)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(115, 39)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close Program"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.btnrecords)
        Me.Controls.Add(Me.lblsub)
        Me.Controls.Add(Me.lblmain)
        Me.Controls.Add(Me.img2)
        Me.Controls.Add(Me.img1)
        Me.Name = "frmmenu"
        Me.Text = "frmmenu"
        CType(Me.img1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents img1 As System.Windows.Forms.PictureBox
    Friend WithEvents img2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblmain As System.Windows.Forms.Label
    Friend WithEvents lblsub As System.Windows.Forms.Label
    Friend WithEvents btnrecords As System.Windows.Forms.Button
    Friend WithEvents btnreport As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
