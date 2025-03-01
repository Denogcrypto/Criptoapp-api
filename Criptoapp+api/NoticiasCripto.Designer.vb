<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoticiasCripto
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
        RichTextBoxNoticias = New RichTextBox()
        ButtonCargarNoticias = New Button()
        SuspendLayout()
        ' 
        ' RichTextBoxNoticias
        ' 
        RichTextBoxNoticias.Location = New Point(154, 48)
        RichTextBoxNoticias.Name = "RichTextBoxNoticias"
        RichTextBoxNoticias.Size = New Size(393, 297)
        RichTextBoxNoticias.TabIndex = 0
        RichTextBoxNoticias.Text = ""
        ' 
        ' ButtonCargarNoticias
        ' 
        ButtonCargarNoticias.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(59))
        ButtonCargarNoticias.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonCargarNoticias.Location = New Point(200, 360)
        ButtonCargarNoticias.Name = "ButtonCargarNoticias"
        ButtonCargarNoticias.Size = New Size(314, 65)
        ButtonCargarNoticias.TabIndex = 1
        ButtonCargarNoticias.Text = "Cargar noticias"
        ButtonCargarNoticias.UseVisualStyleBackColor = False
        ' 
        ' NoticiasCripto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonCargarNoticias)
        Controls.Add(RichTextBoxNoticias)
        Name = "NoticiasCripto"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NoticiasCripto"
        ResumeLayout(False)
    End Sub

    Friend WithEvents RichTextBoxNoticias As RichTextBox
    Friend WithEvents ButtonCargarNoticias As Button
End Class
