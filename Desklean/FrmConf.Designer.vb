<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConf
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSulfixo = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.flGrupos = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.rdTempoRealAtivado = New System.Windows.Forms.RadioButton()
        Me.rdTempoRealDesativado = New System.Windows.Forms.RadioButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.rdLimpezaAtivado = New System.Windows.Forms.RadioButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.rdLimpezaDesativado = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblText = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.rdOutrosAtivado = New System.Windows.Forms.RadioButton()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.rdOutrosDesativado = New System.Windows.Forms.RadioButton()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtSulfixo)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(19, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 59)
        Me.Panel1.TabIndex = 0
        '
        'txtSulfixo
        '
        Me.txtSulfixo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSulfixo.Location = New System.Drawing.Point(40, 25)
        Me.txtSulfixo.Name = "txtSulfixo"
        Me.txtSulfixo.Size = New System.Drawing.Size(290, 27)
        Me.txtSulfixo.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(329, 25)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(46, 27)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "%n%"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.PictureBox1.Image = Global.slimDesk.My.Resources.Resources.active_sessions
        Me.PictureBox1.Location = New System.Drawing.Point(3, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sulfixo de arquivos com nomes iguais"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(10, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(238, 26)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel3.Controls.Add(Me.flGrupos)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Location = New System.Drawing.Point(21, 117)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(381, 138)
        Me.Panel3.TabIndex = 0
        '
        'flGrupos
        '
        Me.flGrupos.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.flGrupos.Location = New System.Drawing.Point(3, 60)
        Me.flGrupos.Name = "flGrupos"
        Me.flGrupos.Size = New System.Drawing.Size(375, 75)
        Me.flGrupos.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(251, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Adicionar Grupo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.PictureBox2.Image = Global.slimDesk.My.Resources.Resources.file_manager
        Me.PictureBox2.Location = New System.Drawing.Point(3, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(5, 110)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(140, 26)
        Me.Panel4.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Grupos de arquivos"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel5.Controls.Add(Me.rdTempoRealAtivado)
        Me.Panel5.Controls.Add(Me.rdTempoRealDesativado)
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Location = New System.Drawing.Point(421, 41)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(381, 59)
        Me.Panel5.TabIndex = 0
        '
        'rdTempoRealAtivado
        '
        Me.rdTempoRealAtivado.AutoSize = True
        Me.rdTempoRealAtivado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdTempoRealAtivado.Location = New System.Drawing.Point(55, 29)
        Me.rdTempoRealAtivado.Name = "rdTempoRealAtivado"
        Me.rdTempoRealAtivado.Size = New System.Drawing.Size(70, 21)
        Me.rdTempoRealAtivado.TabIndex = 0
        Me.rdTempoRealAtivado.TabStop = True
        Me.rdTempoRealAtivado.Text = "Ativado"
        Me.rdTempoRealAtivado.UseVisualStyleBackColor = True
        '
        'rdTempoRealDesativado
        '
        Me.rdTempoRealDesativado.AutoSize = True
        Me.rdTempoRealDesativado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdTempoRealDesativado.Location = New System.Drawing.Point(136, 29)
        Me.rdTempoRealDesativado.Name = "rdTempoRealDesativado"
        Me.rdTempoRealDesativado.Size = New System.Drawing.Size(91, 21)
        Me.rdTempoRealDesativado.TabIndex = 0
        Me.rdTempoRealDesativado.TabStop = True
        Me.rdTempoRealDesativado.Text = "Desativado"
        Me.rdTempoRealDesativado.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.PictureBox3.Image = Global.slimDesk.My.Resources.Resources.zoom_refresh
        Me.PictureBox3.Location = New System.Drawing.Point(3, 22)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Location = New System.Drawing.Point(412, 34)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(320, 26)
        Me.Panel6.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(313, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Processamento de arquivos e pastas em tempo real"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Location = New System.Drawing.Point(412, 110)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(134, 26)
        Me.Panel7.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Limpeza automática"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel8.Controls.Add(Me.rdLimpezaAtivado)
        Me.Panel8.Controls.Add(Me.PictureBox4)
        Me.Panel8.Controls.Add(Me.rdLimpezaDesativado)
        Me.Panel8.Location = New System.Drawing.Point(421, 117)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(381, 59)
        Me.Panel8.TabIndex = 4
        '
        'rdLimpezaAtivado
        '
        Me.rdLimpezaAtivado.AutoSize = True
        Me.rdLimpezaAtivado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdLimpezaAtivado.Location = New System.Drawing.Point(55, 29)
        Me.rdLimpezaAtivado.Name = "rdLimpezaAtivado"
        Me.rdLimpezaAtivado.Size = New System.Drawing.Size(70, 21)
        Me.rdLimpezaAtivado.TabIndex = 0
        Me.rdLimpezaAtivado.TabStop = True
        Me.rdLimpezaAtivado.Text = "Ativado"
        Me.rdLimpezaAtivado.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.PictureBox4.Image = Global.slimDesk.My.Resources.Resources.broom
        Me.PictureBox4.Location = New System.Drawing.Point(3, 22)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'rdLimpezaDesativado
        '
        Me.rdLimpezaDesativado.AutoSize = True
        Me.rdLimpezaDesativado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdLimpezaDesativado.Location = New System.Drawing.Point(136, 29)
        Me.rdLimpezaDesativado.Name = "rdLimpezaDesativado"
        Me.rdLimpezaDesativado.Size = New System.Drawing.Size(91, 21)
        Me.rdLimpezaDesativado.TabIndex = 0
        Me.rdLimpezaDesativado.TabStop = True
        Me.rdLimpezaDesativado.Text = "Desativado"
        Me.rdLimpezaDesativado.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(806, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(26, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Panel9.Controls.Add(Me.lblText)
        Me.Panel9.Location = New System.Drawing.Point(0, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(808, 22)
        Me.Panel9.TabIndex = 3
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(3, 2)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(92, 17)
        Me.lblText.TabIndex = 1
        Me.lblText.Text = "Configurações"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Silver
        Me.Panel10.Location = New System.Drawing.Point(831, -5)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(3, 423)
        Me.Panel10.TabIndex = 8
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Silver
        Me.Panel11.Location = New System.Drawing.Point(0, 1)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(3, 415)
        Me.Panel11.TabIndex = 9
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Silver
        Me.Panel12.Location = New System.Drawing.Point(3, 413)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(831, 3)
        Me.Panel12.TabIndex = 10
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Silver
        Me.Panel13.Location = New System.Drawing.Point(-2, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(836, 3)
        Me.Panel13.TabIndex = 11
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Panel14.Controls.Add(Me.Label5)
        Me.Panel14.Location = New System.Drawing.Point(412, 186)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(330, 26)
        Me.Panel14.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(322, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Colocar arquivos não configurados em pasta 'Outros'"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel15.Controls.Add(Me.rdOutrosAtivado)
        Me.Panel15.Controls.Add(Me.PictureBox5)
        Me.Panel15.Controls.Add(Me.rdOutrosDesativado)
        Me.Panel15.Location = New System.Drawing.Point(421, 193)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(381, 59)
        Me.Panel15.TabIndex = 12
        '
        'rdOutrosAtivado
        '
        Me.rdOutrosAtivado.AutoSize = True
        Me.rdOutrosAtivado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdOutrosAtivado.Location = New System.Drawing.Point(55, 29)
        Me.rdOutrosAtivado.Name = "rdOutrosAtivado"
        Me.rdOutrosAtivado.Size = New System.Drawing.Size(70, 21)
        Me.rdOutrosAtivado.TabIndex = 0
        Me.rdOutrosAtivado.TabStop = True
        Me.rdOutrosAtivado.Text = "Ativado"
        Me.rdOutrosAtivado.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.PictureBox5.Image = Global.slimDesk.My.Resources.Resources.emotion_question
        Me.PictureBox5.Location = New System.Drawing.Point(3, 22)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'rdOutrosDesativado
        '
        Me.rdOutrosDesativado.AutoSize = True
        Me.rdOutrosDesativado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdOutrosDesativado.Location = New System.Drawing.Point(136, 29)
        Me.rdOutrosDesativado.Name = "rdOutrosDesativado"
        Me.rdOutrosDesativado.Size = New System.Drawing.Size(91, 21)
        Me.rdOutrosDesativado.TabIndex = 0
        Me.rdOutrosDesativado.TabStop = True
        Me.rdOutrosDesativado.Text = "Desativado"
        Me.rdOutrosDesativado.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Image = Global.slimDesk.My.Resources.Resources.door_in
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(626, 343)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(83, 64)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Image = Global.slimDesk.My.Resources.Resources.disk
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvar.Location = New System.Drawing.Point(715, 343)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(87, 64)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Panel16.Controls.Add(Me.Label6)
        Me.Panel16.Location = New System.Drawing.Point(5, 262)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(176, 26)
        Me.Panel16.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Configurar arquivos fixos"
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel17.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel17.Controls.Add(Me.Button5)
        Me.Panel17.Controls.Add(Me.PictureBox6)
        Me.Panel17.Location = New System.Drawing.Point(21, 269)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(381, 138)
        Me.Panel17.TabIndex = 14
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 60)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(375, 75)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(251, 31)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 26)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Configurar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.PictureBox6.Image = Global.slimDesk.My.Resources.Resources.three_tags
        Me.PictureBox6.Location = New System.Drawing.Point(3, 22)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 3
        Me.PictureBox6.TabStop = False
        '
        'FrmConf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(834, 416)
        Me.Controls.Add(Me.Panel16)
        Me.Controls.Add(Me.Panel17)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmConf"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurações"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtSulfixo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents flGrupos As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents rdTempoRealAtivado As System.Windows.Forms.RadioButton
    Friend WithEvents rdTempoRealDesativado As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents rdLimpezaAtivado As System.Windows.Forms.RadioButton
    Friend WithEvents rdLimpezaDesativado As System.Windows.Forms.RadioButton
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents rdOutrosAtivado As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents rdOutrosDesativado As System.Windows.Forms.RadioButton
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
End Class
