<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        cargarprecios = New Button()
        Button2 = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' cargarprecios
        ' 
        cargarprecios.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(59))
        cargarprecios.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cargarprecios.Location = New Point(31, 39)
        cargarprecios.Name = "cargarprecios"
        cargarprecios.Size = New Size(285, 85)
        cargarprecios.TabIndex = 0
        cargarprecios.Text = "Precios "
        cargarprecios.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(59))
        Button2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(31, 147)
        Button2.Name = "Button2"
        Button2.Size = New Size(285, 85)
        Button2.TabIndex = 1
        Button2.Text = "Noticias Cripto"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(59))
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(31, 263)
        Button1.Name = "Button1"
        Button1.Size = New Size(285, 84)
        Button1.TabIndex = 2
        Button1.Text = "Mi Portafolio"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(cargarprecios)
        Name = "Inicio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inicio"
        ResumeLayout(False)
    End Sub

    Friend WithEvents cargarprecios As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
