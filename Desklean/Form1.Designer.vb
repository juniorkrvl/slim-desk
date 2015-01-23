<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.mnuOpcoes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LimparAgoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Notify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Splash = New System.Windows.Forms.Timer(Me.components)
        Me.mnuOpcoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Interval = 5000
        '
        'mnuOpcoes
        '
        Me.mnuOpcoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimparAgoraToolStripMenuItem, Me.ConfiguraçõesToolStripMenuItem, Me.ToolStripMenuItem1, Me.SairToolStripMenuItem})
        Me.mnuOpcoes.Name = "mnuOpcoes"
        Me.mnuOpcoes.Size = New System.Drawing.Size(152, 76)
        '
        'LimparAgoraToolStripMenuItem
        '
        Me.LimparAgoraToolStripMenuItem.Name = "LimparAgoraToolStripMenuItem"
        Me.LimparAgoraToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.LimparAgoraToolStripMenuItem.Text = "Limpar Agora"
        '
        'ConfiguraçõesToolStripMenuItem
        '
        Me.ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        Me.ConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ConfiguraçõesToolStripMenuItem.Text = "Configurações"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(148, 6)
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'Notify
        '
        Me.Notify.ContextMenuStrip = Me.mnuOpcoes
        Me.Notify.Icon = CType(resources.GetObject("Notify.Icon"), System.Drawing.Icon)
        Me.Notify.Text = "Desklean"
        Me.Notify.Visible = True
        '
        'Splash
        '
        Me.Splash.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(13, 13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.mnuOpcoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents mnuOpcoes As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Notify As System.Windows.Forms.NotifyIcon
    Friend WithEvents ConfiguraçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimparAgoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Splash As System.Windows.Forms.Timer

End Class
