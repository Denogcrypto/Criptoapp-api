<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        ButtonCargar = New Button()
        CriptoApp = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 67)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(776, 279)
        DataGridView1.TabIndex = 0
        ' 
        ' ButtonCargar
        ' 
        ButtonCargar.BackColor = Color.FromArgb(CByte(179), CByte(255), CByte(59))
        ButtonCargar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonCargar.ForeColor = Color.Black
        ButtonCargar.Location = New Point(247, 363)
        ButtonCargar.Name = "ButtonCargar"
        ButtonCargar.Size = New Size(256, 66)
        ButtonCargar.TabIndex = 1
        ButtonCargar.Text = "Cargar Datos"
        ButtonCargar.UseVisualStyleBackColor = False
        ' 
        ' CriptoApp
        ' 
        CriptoApp.AutoSize = True
        CriptoApp.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CriptoApp.ForeColor = Color.Silver
        CriptoApp.Location = New Point(295, 31)
        CriptoApp.Name = "CriptoApp"
        CriptoApp.Size = New Size(169, 17)
        CriptoApp.TabIndex = 2
        CriptoApp.Text = "Precios de Criptomonedas"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        ClientSize = New Size(800, 450)
        Controls.Add(CriptoApp)
        Controls.Add(ButtonCargar)
        Controls.Add(DataGridView1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonCargar As Button
    Friend WithEvents CriptoApp As Label

End Class
