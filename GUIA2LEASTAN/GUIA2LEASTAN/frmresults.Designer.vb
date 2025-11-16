<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmresults
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmresults))
        Me.lblquestionnum = New System.Windows.Forms.Label
        Me.PicWellDone = New System.Windows.Forms.PictureBox
        Me.PicRestart = New System.Windows.Forms.PictureBox
        Me.lblresultstxt = New System.Windows.Forms.Label
        Me.lbltimetaken = New System.Windows.Forms.Label
        Me.cmdnext = New System.Windows.Forms.Button
        Me.btnretry = New System.Windows.Forms.Button
        CType(Me.PicWellDone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRestart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblquestionnum
        '
        Me.lblquestionnum.AutoSize = True
        Me.lblquestionnum.Location = New System.Drawing.Point(60, 92)
        Me.lblquestionnum.Name = "lblquestionnum"
        Me.lblquestionnum.Size = New System.Drawing.Size(0, 13)
        Me.lblquestionnum.TabIndex = 184
        '
        'PicWellDone
        '
        Me.PicWellDone.Image = CType(resources.GetObject("PicWellDone.Image"), System.Drawing.Image)
        Me.PicWellDone.Location = New System.Drawing.Point(455, 92)
        Me.PicWellDone.Name = "PicWellDone"
        Me.PicWellDone.Size = New System.Drawing.Size(152, 170)
        Me.PicWellDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicWellDone.TabIndex = 186
        Me.PicWellDone.TabStop = False
        '
        'PicRestart
        '
        Me.PicRestart.Image = CType(resources.GetObject("PicRestart.Image"), System.Drawing.Image)
        Me.PicRestart.Location = New System.Drawing.Point(455, 92)
        Me.PicRestart.Name = "PicRestart"
        Me.PicRestart.Size = New System.Drawing.Size(152, 170)
        Me.PicRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRestart.TabIndex = 187
        Me.PicRestart.TabStop = False
        '
        'lblresultstxt
        '
        Me.lblresultstxt.AutoSize = True
        Me.lblresultstxt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblresultstxt.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblresultstxt.ForeColor = System.Drawing.Color.Teal
        Me.lblresultstxt.Location = New System.Drawing.Point(60, 92)
        Me.lblresultstxt.Name = "lblresultstxt"
        Me.lblresultstxt.Size = New System.Drawing.Size(74, 17)
        Me.lblresultstxt.TabIndex = 189
        Me.lblresultstxt.Text = "Final score"
        '
        'lbltimetaken
        '
        Me.lbltimetaken.AutoSize = True
        Me.lbltimetaken.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbltimetaken.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbltimetaken.ForeColor = System.Drawing.Color.Teal
        Me.lbltimetaken.Location = New System.Drawing.Point(60, 167)
        Me.lbltimetaken.Name = "lbltimetaken"
        Me.lbltimetaken.Size = New System.Drawing.Size(147, 17)
        Me.lbltimetaken.TabIndex = 190
        Me.lbltimetaken.Text = "Time to complete quiz"
        '
        'cmdnext
        '
        Me.cmdnext.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdnext.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdnext.ForeColor = System.Drawing.Color.Teal
        Me.cmdnext.Location = New System.Drawing.Point(300, 443)
        Me.cmdnext.Name = "cmdnext"
        Me.cmdnext.Size = New System.Drawing.Size(115, 37)
        Me.cmdnext.TabIndex = 191
        Me.cmdnext.Text = "Exit"
        Me.cmdnext.UseVisualStyleBackColor = False
        '
        'btnretry
        '
        Me.btnretry.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnretry.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnretry.ForeColor = System.Drawing.Color.Teal
        Me.btnretry.Location = New System.Drawing.Point(474, 282)
        Me.btnretry.Name = "btnretry"
        Me.btnretry.Size = New System.Drawing.Size(115, 39)
        Me.btnretry.TabIndex = 193
        Me.btnretry.Text = "Retry Quiz"
        Me.btnretry.UseVisualStyleBackColor = False
        Me.btnretry.Visible = False
        '
        'frmresults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.btnretry)
        Me.Controls.Add(Me.cmdnext)
        Me.Controls.Add(Me.lbltimetaken)
        Me.Controls.Add(Me.lblresultstxt)
        Me.Controls.Add(Me.PicRestart)
        Me.Controls.Add(Me.PicWellDone)
        Me.Controls.Add(Me.lblquestionnum)
        Me.Name = "frmresults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmresults"
        CType(Me.PicWellDone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRestart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblquestionnum As System.Windows.Forms.Label
    Friend WithEvents PicWellDone As System.Windows.Forms.PictureBox
    Friend WithEvents PicRestart As System.Windows.Forms.PictureBox
    Friend WithEvents lblresultstxt As System.Windows.Forms.Label
    Friend WithEvents lbltimetaken As System.Windows.Forms.Label
    Friend WithEvents cmdnext As System.Windows.Forms.Button
    Friend WithEvents btnretry As System.Windows.Forms.Button
End Class
