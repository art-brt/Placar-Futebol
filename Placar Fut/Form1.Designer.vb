<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCasa = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblVisitante = New System.Windows.Forms.Label()
        Me.btnCasa = New System.Windows.Forms.Button()
        Me.btnVisitante = New System.Windows.Forms.Button()
        Me.cbbCasa = New System.Windows.Forms.ComboBox()
        Me.ptbCasa = New System.Windows.Forms.PictureBox()
        Me.ptbVisitante = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnComecar = New System.Windows.Forms.Button()
        Me.pgbTempo = New System.Windows.Forms.ProgressBar()
        Me.lblMinutos = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbbVisitante = New System.Windows.Forms.ComboBox()
        CType(Me.ptbCasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbVisitante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Time da Casa:"
        '
        'lblCasa
        '
        Me.lblCasa.AutoSize = True
        Me.lblCasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCasa.Location = New System.Drawing.Point(96, 75)
        Me.lblCasa.Name = "lblCasa"
        Me.lblCasa.Size = New System.Drawing.Size(37, 39)
        Me.lblCasa.TabIndex = 1
        Me.lblCasa.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(634, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Time Visitante:"
        '
        'lblVisitante
        '
        Me.lblVisitante.AutoSize = True
        Me.lblVisitante.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitante.Location = New System.Drawing.Point(654, 75)
        Me.lblVisitante.Name = "lblVisitante"
        Me.lblVisitante.Size = New System.Drawing.Size(37, 39)
        Me.lblVisitante.TabIndex = 3
        Me.lblVisitante.Text = "0"
        '
        'btnCasa
        '
        Me.btnCasa.Enabled = False
        Me.btnCasa.Location = New System.Drawing.Point(78, 127)
        Me.btnCasa.Name = "btnCasa"
        Me.btnCasa.Size = New System.Drawing.Size(72, 31)
        Me.btnCasa.TabIndex = 4
        Me.btnCasa.Text = "GOOOL!"
        Me.btnCasa.UseVisualStyleBackColor = True
        '
        'btnVisitante
        '
        Me.btnVisitante.Enabled = False
        Me.btnVisitante.Location = New System.Drawing.Point(637, 127)
        Me.btnVisitante.Name = "btnVisitante"
        Me.btnVisitante.Size = New System.Drawing.Size(72, 31)
        Me.btnVisitante.TabIndex = 5
        Me.btnVisitante.Text = "GOOOL!"
        Me.btnVisitante.UseVisualStyleBackColor = True
        '
        'cbbCasa
        '
        Me.cbbCasa.FormattingEnabled = True
        Me.cbbCasa.Items.AddRange(New Object() {"", "Al Mossar", "Meia Boca Juniors", "Patético de Madrid", "Shaktar dos Leks"})
        Me.cbbCasa.Location = New System.Drawing.Point(38, 187)
        Me.cbbCasa.Name = "cbbCasa"
        Me.cbbCasa.Size = New System.Drawing.Size(159, 21)
        Me.cbbCasa.TabIndex = 6
        '
        'ptbCasa
        '
        Me.ptbCasa.Location = New System.Drawing.Point(38, 244)
        Me.ptbCasa.Name = "ptbCasa"
        Me.ptbCasa.Size = New System.Drawing.Size(159, 164)
        Me.ptbCasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbCasa.TabIndex = 8
        Me.ptbCasa.TabStop = False
        '
        'ptbVisitante
        '
        Me.ptbVisitante.Location = New System.Drawing.Point(594, 244)
        Me.ptbVisitante.Name = "ptbVisitante"
        Me.ptbVisitante.Size = New System.Drawing.Size(159, 164)
        Me.ptbVisitante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbVisitante.TabIndex = 9
        Me.ptbVisitante.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnComecar)
        Me.GroupBox1.Controls.Add(Me.pgbTempo)
        Me.GroupBox1.Controls.Add(Me.lblMinutos)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(237, 187)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 220)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tempo"
        '
        'btnComecar
        '
        Me.btnComecar.Enabled = False
        Me.btnComecar.Location = New System.Drawing.Point(113, 155)
        Me.btnComecar.Name = "btnComecar"
        Me.btnComecar.Size = New System.Drawing.Size(75, 23)
        Me.btnComecar.TabIndex = 3
        Me.btnComecar.Text = "Começar"
        Me.btnComecar.UseVisualStyleBackColor = True
        '
        'pgbTempo
        '
        Me.pgbTempo.Location = New System.Drawing.Point(40, 108)
        Me.pgbTempo.Maximum = 90
        Me.pgbTempo.Name = "pgbTempo"
        Me.pgbTempo.Size = New System.Drawing.Size(229, 27)
        Me.pgbTempo.Step = 1
        Me.pgbTempo.TabIndex = 2
        '
        'lblMinutos
        '
        Me.lblMinutos.AutoSize = True
        Me.lblMinutos.Location = New System.Drawing.Point(91, 57)
        Me.lblMinutos.Name = "lblMinutos"
        Me.lblMinutos.Size = New System.Drawing.Size(13, 13)
        Me.lblMinutos.TabIndex = 1
        Me.lblMinutos.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Minutos:"
        '
        'cbbVisitante
        '
        Me.cbbVisitante.FormattingEnabled = True
        Me.cbbVisitante.Items.AddRange(New Object() {"", "Al Mossar", "Meia Boca Juniors", "Patético de Madrid", "Shaktar dos Leks"})
        Me.cbbVisitante.Location = New System.Drawing.Point(594, 187)
        Me.cbbVisitante.Name = "cbbVisitante"
        Me.cbbVisitante.Size = New System.Drawing.Size(159, 21)
        Me.cbbVisitante.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 464)
        Me.Controls.Add(Me.cbbVisitante)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ptbVisitante)
        Me.Controls.Add(Me.ptbCasa)
        Me.Controls.Add(Me.cbbCasa)
        Me.Controls.Add(Me.btnVisitante)
        Me.Controls.Add(Me.btnCasa)
        Me.Controls.Add(Me.lblVisitante)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCasa)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Placar Eletrônico"
        CType(Me.ptbCasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbVisitante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCasa As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblVisitante As Label
    Friend WithEvents btnCasa As Button
    Friend WithEvents btnVisitante As Button
    Friend WithEvents cbbCasa As ComboBox
    Friend WithEvents ptbCasa As PictureBox
    Friend WithEvents ptbVisitante As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblMinutos As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnComecar As Button
    Friend WithEvents pgbTempo As ProgressBar
    Friend WithEvents cbbVisitante As ComboBox
End Class
