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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AluguelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarrosDisponíveisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AluguéisPorPlacaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Red
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1030, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastrarToolStripMenuItem
        '
        Me.CadastrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuncionárioToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.CarroToolStripMenuItem, Me.AluguelToolStripMenuItem})
        Me.CadastrarToolStripMenuItem.Name = "CadastrarToolStripMenuItem"
        Me.CadastrarToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.CadastrarToolStripMenuItem.Text = "&Cadastrar"
        '
        'FuncionárioToolStripMenuItem
        '
        Me.FuncionárioToolStripMenuItem.Name = "FuncionárioToolStripMenuItem"
        Me.FuncionárioToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.FuncionárioToolStripMenuItem.Text = "&Funcionário..."
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ClienteToolStripMenuItem.Text = "Clie&nte..."
        '
        'CarroToolStripMenuItem
        '
        Me.CarroToolStripMenuItem.Name = "CarroToolStripMenuItem"
        Me.CarroToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CarroToolStripMenuItem.Text = "Carr&o..."
        '
        'AluguelToolStripMenuItem
        '
        Me.AluguelToolStripMenuItem.Name = "AluguelToolStripMenuItem"
        Me.AluguelToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.AluguelToolStripMenuItem.Text = "&Aluguel..."
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CarrosDisponíveisToolStripMenuItem, Me.AluguéisPorPlacaToolStripMenuItem})
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ConsultarToolStripMenuItem.Text = "Cons&ultar"
        '
        'CarrosDisponíveisToolStripMenuItem
        '
        Me.CarrosDisponíveisToolStripMenuItem.Name = "CarrosDisponíveisToolStripMenuItem"
        Me.CarrosDisponíveisToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CarrosDisponíveisToolStripMenuItem.Text = "Carros D&isponíveis..."
        '
        'AluguéisPorPlacaToolStripMenuItem
        '
        Me.AluguéisPorPlacaToolStripMenuItem.Name = "AluguéisPorPlacaToolStripMenuItem"
        Me.AluguéisPorPlacaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AluguéisPorPlacaToolStripMenuItem.Text = "Aluguéis por &placa..."
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "A&juda"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SobreToolStripMenuItem.Text = "&Sobre..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.sgac2023.My.Resources.Resources.maxresdefault
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1030, 557)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "SGAC2023"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AluguelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarrosDisponíveisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AluguéisPorPlacaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
End Class
