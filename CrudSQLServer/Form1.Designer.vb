<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.BtnRead = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.TxtAge = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.LblID = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblAge = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(106, 103)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(100, 20)
        Me.TxtName.TabIndex = 0
        '
        'BtnRead
        '
        Me.BtnRead.Location = New System.Drawing.Point(78, 278)
        Me.BtnRead.Name = "BtnRead"
        Me.BtnRead.Size = New System.Drawing.Size(128, 23)
        Me.BtnRead.TabIndex = 1
        Me.BtnRead.Text = "Leer todos los registros"
        Me.BtnRead.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(274, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(442, 224)
        Me.DataGridView1.TabIndex = 2
        '
        'BtnCreate
        '
        Me.BtnCreate.Location = New System.Drawing.Point(78, 191)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(128, 23)
        Me.BtnCreate.TabIndex = 3
        Me.BtnCreate.Text = "Crear Persona"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(78, 249)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(128, 23)
        Me.BtnUpdate.TabIndex = 4
        Me.BtnUpdate.Text = "Actualizar Persona"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(78, 220)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(128, 23)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.Text = "Eliminar Persona"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'TxtAge
        '
        Me.TxtAge.Location = New System.Drawing.Point(106, 129)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(100, 20)
        Me.TxtAge.TabIndex = 6
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(106, 77)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 7
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(71, 80)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(18, 13)
        Me.LblID.TabIndex = 8
        Me.LblID.Text = "ID"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(45, 106)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(44, 13)
        Me.LblName.TabIndex = 9
        Me.LblName.Text = "Nombre"
        '
        'LblAge
        '
        Me.LblAge.AutoSize = True
        Me.LblAge.Location = New System.Drawing.Point(57, 132)
        Me.LblAge.Name = "LblAge"
        Me.LblAge.Size = New System.Drawing.Size(32, 13)
        Me.LblAge.TabIndex = 10
        Me.LblAge.Text = "Edad"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblAge)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.TxtAge)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnRead)
        Me.Controls.Add(Me.TxtName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtName As TextBox
    Friend WithEvents BtnRead As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents TxtAge As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents LblID As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblAge As Label
End Class
