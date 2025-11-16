<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddRecords))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblmain = New System.Windows.Forms.Label
        Me.btnrecords = New System.Windows.Forms.Button
        Me.btnMenu = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(340, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblmain
        '
        Me.lblmain.BackColor = System.Drawing.Color.Teal
        Me.lblmain.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmain.Location = New System.Drawing.Point(356, 219)
        Me.lblmain.Name = "lblmain"
        Me.lblmain.Size = New System.Drawing.Size(345, 46)
        Me.lblmain.TabIndex = 8
        Me.lblmain.Text = "STUDENT RECORD MANAGEMENT SYSTEM"
        Me.lblmain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnrecords
        '
        Me.btnrecords.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnrecords.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrecords.ForeColor = System.Drawing.Color.Teal
        Me.btnrecords.Location = New System.Drawing.Point(456, 330)
        Me.btnrecords.Name = "btnrecords"
        Me.btnrecords.Size = New System.Drawing.Size(161, 44)
        Me.btnrecords.TabIndex = 10
        Me.btnrecords.Text = "Add Student Records"
        Me.btnrecords.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.Color.Teal
        Me.btnMenu.Location = New System.Drawing.Point(456, 390)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(161, 44)
        Me.btnMenu.TabIndex = 12
        Me.btnMenu.Text = "Return To Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'frmAddRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnrecords)
        Me.Controls.Add(Me.lblmain)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmAddRecords"
        Me.Text = "frmAddRecords"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblmain As System.Windows.Forms.Label
    Friend WithEvents btnrecords As System.Windows.Forms.Button
    Friend WithEvents btnMenu As System.Windows.Forms.Button
End Class
