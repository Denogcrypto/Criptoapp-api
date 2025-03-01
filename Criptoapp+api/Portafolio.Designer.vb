<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Portafolio
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
        TextBoxCantidad = New TextBox()
        DataGridViewPortafolio = New DataGridView()
        ComboBoxCriptomonedas = New ComboBox()
        ButtonAgregar = New Button()
        LabelValorTotal = New Label()
        Label1 = New Label()
        Label2 = New Label()
        CType(DataGridViewPortafolio, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBoxCantidad
        ' 
        TextBoxCantidad.Location = New Point(323, 72)
        TextBoxCantidad.Name = "TextBoxCantidad"
        TextBoxCantidad.Size = New Size(121, 23)
        TextBoxCantidad.TabIndex = 0
        ' 
        ' DataGridViewPortafolio
        ' 
        DataGridViewPortafolio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewPortafolio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPortafolio.Location = New Point(12, 147)
        DataGridViewPortafolio.Name = "DataGridViewPortafolio"
        DataGridViewPortafolio.Size = New Size(776, 252)
        DataGridViewPortafolio.TabIndex = 1
        ' 
        ' ComboBoxCriptomonedas
        ' 
        ComboBoxCriptomonedas.FormattingEnabled = True
        ComboBoxCriptomonedas.Location = New Point(323, 27)
        ComboBoxCriptomonedas.Name = "ComboBoxCriptomonedas"
        ComboBoxCriptomonedas.Size = New Size(121, 23)
        ComboBoxCriptomonedas.TabIndex = 2
        ' 
        ' ButtonAgregar
        ' 
        ButtonAgregar.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(59))
        ButtonAgregar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonAgregar.Location = New Point(323, 101)
        ButtonAgregar.Name = "ButtonAgregar"
        ButtonAgregar.Size = New Size(121, 40)
        ButtonAgregar.TabIndex = 3
        ButtonAgregar.Text = "Agregar"
        ButtonAgregar.UseVisualStyleBackColor = False
        ' 
        ' LabelValorTotal
        ' 
        LabelValorTotal.AutoSize = True
        LabelValorTotal.Location = New Point(314, 412)
        LabelValorTotal.Name = "LabelValorTotal"
        LabelValorTotal.Size = New Size(135, 15)
        LabelValorTotal.TabIndex = 4
        LabelValorTotal.Text = "Valor Total del Portafolio"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(314, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 17)
        Label1.TabIndex = 5
        Label1.Text = "Selecciona la Cantidad"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(273, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(265, 17)
        Label2.TabIndex = 6
        Label2.Text = "Seleccione la moneda y luego la Cantidad"
        ' 
        ' Portafolio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LabelValorTotal)
        Controls.Add(ButtonAgregar)
        Controls.Add(ComboBoxCriptomonedas)
        Controls.Add(DataGridViewPortafolio)
        Controls.Add(TextBoxCantidad)
        Name = "Portafolio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Portafolio"
        CType(DataGridViewPortafolio, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxCantidad As TextBox
    Friend WithEvents DataGridViewPortafolio As DataGridView
    Friend WithEvents ComboBoxCriptomonedas As ComboBox
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents LabelValorTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
