<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnJugar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PBox1 = New System.Windows.Forms.PictureBox()
        Me.LblCasilla1 = New System.Windows.Forms.Label()
        Me.LblCasilla2 = New System.Windows.Forms.Label()
        Me.LblCasilla3 = New System.Windows.Forms.Label()
        Me.LblEstadísticas = New System.Windows.Forms.Label()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.LblGanados = New System.Windows.Forms.Label()
        Me.LblJugadas = New System.Windows.Forms.Label()
        Me.LblTítulo = New System.Windows.Forms.Label()
        Me.LblPorcentage = New System.Windows.Forms.Label()
        Me.LblSuerte = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnJugar
        '
        Me.BtnJugar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnJugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJugar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnJugar.Location = New System.Drawing.Point(174, 50)
        Me.BtnJugar.Name = "BtnJugar"
        Me.BtnJugar.Size = New System.Drawing.Size(120, 322)
        Me.BtnJugar.TabIndex = 0
        Me.BtnJugar.Text = "¡Presione Aquí, o la tecla Enter para Jugar!"
        Me.BtnJugar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSalir.Location = New System.Drawing.Point(209, 395)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(55, 32)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'PBox1
        '
        Me.PBox1.Image = CType(resources.GetObject("PBox1.Image"), System.Drawing.Image)
        Me.PBox1.Location = New System.Drawing.Point(312, 210)
        Me.PBox1.Name = "PBox1"
        Me.PBox1.Size = New System.Drawing.Size(430, 228)
        Me.PBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBox1.TabIndex = 2
        Me.PBox1.TabStop = False
        Me.PBox1.Visible = False
        '
        'LblCasilla1
        '
        Me.LblCasilla1.BackColor = System.Drawing.Color.White
        Me.LblCasilla1.Font = New System.Drawing.Font("Microsoft Sans Serif", 100.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCasilla1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblCasilla1.Location = New System.Drawing.Point(312, 50)
        Me.LblCasilla1.Name = "LblCasilla1"
        Me.LblCasilla1.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.LblCasilla1.Size = New System.Drawing.Size(130, 150)
        Me.LblCasilla1.TabIndex = 3
        Me.LblCasilla1.Text = "0"
        Me.LblCasilla1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCasilla2
        '
        Me.LblCasilla2.BackColor = System.Drawing.Color.White
        Me.LblCasilla2.Font = New System.Drawing.Font("Microsoft Sans Serif", 100.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCasilla2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblCasilla2.Location = New System.Drawing.Point(462, 50)
        Me.LblCasilla2.Name = "LblCasilla2"
        Me.LblCasilla2.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.LblCasilla2.Size = New System.Drawing.Size(130, 150)
        Me.LblCasilla2.TabIndex = 4
        Me.LblCasilla2.Text = "0"
        Me.LblCasilla2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCasilla3
        '
        Me.LblCasilla3.BackColor = System.Drawing.Color.White
        Me.LblCasilla3.Font = New System.Drawing.Font("Microsoft Sans Serif", 100.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCasilla3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblCasilla3.Location = New System.Drawing.Point(613, 50)
        Me.LblCasilla3.Name = "LblCasilla3"
        Me.LblCasilla3.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.LblCasilla3.Size = New System.Drawing.Size(130, 150)
        Me.LblCasilla3.TabIndex = 5
        Me.LblCasilla3.Text = "0"
        Me.LblCasilla3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEstadísticas
        '
        Me.LblEstadísticas.AutoSize = True
        Me.LblEstadísticas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstadísticas.Location = New System.Drawing.Point(27, 88)
        Me.LblEstadísticas.Name = "LblEstadísticas"
        Me.LblEstadísticas.Size = New System.Drawing.Size(116, 25)
        Me.LblEstadísticas.TabIndex = 6
        Me.LblEstadísticas.Text = "Estadísticas"
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.Location = New System.Drawing.Point(6, 142)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(162, 25)
        Me.Lbl1.TabIndex = 7
        Me.Lbl1.Text = "Juegos Ganados"
        '
        'LblGanados
        '
        Me.LblGanados.BackColor = System.Drawing.Color.White
        Me.LblGanados.Location = New System.Drawing.Point(48, 194)
        Me.LblGanados.Name = "LblGanados"
        Me.LblGanados.Size = New System.Drawing.Size(70, 23)
        Me.LblGanados.TabIndex = 8
        '
        'LblJugadas
        '
        Me.LblJugadas.BackColor = System.Drawing.Color.White
        Me.LblJugadas.Location = New System.Drawing.Point(48, 349)
        Me.LblJugadas.Name = "LblJugadas"
        Me.LblJugadas.Size = New System.Drawing.Size(70, 23)
        Me.LblJugadas.TabIndex = 9
        '
        'LblTítulo
        '
        Me.LblTítulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblTítulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTítulo.Location = New System.Drawing.Point(174, 9)
        Me.LblTítulo.Name = "LblTítulo"
        Me.LblTítulo.Size = New System.Drawing.Size(568, 31)
        Me.LblTítulo.TabIndex = 10
        Me.LblTítulo.Text = "¡Gana¡ con un 7 en la primera casilla, o si las dos últimas casillas tienen 7"
        Me.LblTítulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPorcentage
        '
        Me.LblPorcentage.BackColor = System.Drawing.Color.White
        Me.LblPorcentage.Location = New System.Drawing.Point(48, 264)
        Me.LblPorcentage.Name = "LblPorcentage"
        Me.LblPorcentage.Size = New System.Drawing.Size(70, 23)
        Me.LblPorcentage.TabIndex = 11
        '
        'LblSuerte
        '
        Me.LblSuerte.AutoSize = True
        Me.LblSuerte.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSuerte.Location = New System.Drawing.Point(46, 37)
        Me.LblSuerte.Name = "LblSuerte"
        Me.LblSuerte.Size = New System.Drawing.Size(83, 25)
        Me.LblSuerte.TabIndex = 12
        Me.LblSuerte.Text = "¡Suerte!"
        Me.LblSuerte.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Jugadas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblSuerte)
        Me.Controls.Add(Me.LblPorcentage)
        Me.Controls.Add(Me.LblTítulo)
        Me.Controls.Add(Me.LblJugadas)
        Me.Controls.Add(Me.LblGanados)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.LblEstadísticas)
        Me.Controls.Add(Me.LblCasilla3)
        Me.Controls.Add(Me.LblCasilla2)
        Me.Controls.Add(Me.LblCasilla1)
        Me.Controls.Add(Me.PBox1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnJugar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnJugar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents PBox1 As PictureBox
    Friend WithEvents LblCasilla1 As Label
    Friend WithEvents LblCasilla2 As Label
    Friend WithEvents LblCasilla3 As Label
    Friend WithEvents LblEstadísticas As Label
    Friend WithEvents Lbl1 As Label
    Friend WithEvents LblGanados As Label
    Friend WithEvents LblJugadas As Label
    Friend WithEvents LblTítulo As Label
    Friend WithEvents LblPorcentage As Label
    Friend WithEvents LblSuerte As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
