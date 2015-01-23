<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserGrupo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.picExt = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.picExt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoEllipsis = True
        Me.lblGrupo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupo.Location = New System.Drawing.Point(2, 0)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(52, 15)
        Me.lblGrupo.TabIndex = 5
        Me.lblGrupo.Text = "Imagens"
        Me.lblGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picExt
        '
        Me.picExt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picExt.Image = Global.slimDesk.My.Resources.Resources.information
        Me.picExt.Location = New System.Drawing.Point(28, 34)
        Me.picExt.Name = "picExt"
        Me.picExt.Size = New System.Drawing.Size(16, 16)
        Me.picExt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExt.TabIndex = 6
        Me.picExt.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.slimDesk.My.Resources.Resources.folder_blue
        Me.PictureBox2.Location = New System.Drawing.Point(12, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'UserGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.picExt)
        Me.Controls.Add(Me.lblGrupo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "UserGrupo"
        Me.Size = New System.Drawing.Size(54, 54)
        CType(Me.picExt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents picExt As System.Windows.Forms.PictureBox

End Class
