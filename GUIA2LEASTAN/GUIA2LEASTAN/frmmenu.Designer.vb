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
        Me.btnClose = New System.Windows.Forms.Button
        Me.btncalculator = New System.Windows.Forms.Button
        Me.btnmcq = New System.Windows.Forms.Button
        Me.lblmain = New System.Windows.Forms.Label
        Me.btnhelp = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Teal
        Me.btnClose.Location = New System.Drawing.Point(290, 367)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(115, 39)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close Program"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btncalculator
        '
        Me.btncalculator.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncalculator.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalculator.ForeColor = System.Drawing.Color.Teal
        Me.btncalculator.Location = New System.Drawing.Point(290, 261)
        Me.btncalculator.Name = "btncalculator"
        Me.btncalculator.Size = New System.Drawing.Size(115, 55)
        Me.btncalculator.TabIndex = 15
        Me.btncalculator.Text = "Calculator"
        Me.btncalculator.UseVisualStyleBackColor = False
        '
        'btnmcq
        '
        Me.btnmcq.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmcq.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmcq.ForeColor = System.Drawing.Color.Teal
        Me.btnmcq.Location = New System.Drawing.Point(290, 197)
        Me.btnmcq.Name = "btnmcq"
        Me.btnmcq.Size = New System.Drawing.Size(115, 58)
        Me.btnmcq.TabIndex = 14
        Me.btnmcq.Text = "MCQ Test"
        Me.btnmcq.UseVisualStyleBackColor = False
        '
        'lblmain
        '
        Me.lblmain.BackColor = System.Drawing.Color.Teal
        Me.lblmain.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmain.Location = New System.Drawing.Point(240, 87)
        Me.lblmain.Name = "lblmain"
        Me.lblmain.Size = New System.Drawing.Size(208, 46)
        Me.lblmain.TabIndex = 12
        Me.lblmain.Text = "Main Menu"
        Me.lblmain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnhelp
        '
        Me.btnhelp.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnhelp.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhelp.ForeColor = System.Drawing.Color.Teal
        Me.btnhelp.Location = New System.Drawing.Point(290, 322)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(115, 39)
        Me.btnhelp.TabIndex = 17
        Me.btnhelp.Text = "Help"
        Me.btnhelp.UseVisualStyleBackColor = False
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.btnhelp)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btncalculator)
        Me.Controls.Add(Me.btnmcq)
        Me.Controls.Add(Me.lblmain)
        Me.Name = "frmmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmmenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btncalculator As System.Windows.Forms.Button
    Friend WithEvents btnmcq As System.Windows.Forms.Button
    Friend WithEvents lblmain As System.Windows.Forms.Label
    Friend WithEvents btnhelp As System.Windows.Forms.Button
End Class
