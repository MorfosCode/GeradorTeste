namespace GeradorTeste.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            disciplinaMenuItem = new ToolStripMenuItem();
            materiaMenuItem = new ToolStripMenuItem();
            questãoMenuItem = new ToolStripMenuItem();
            pnlRegistros = new Panel();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnDuplicaar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            btnPdf = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnVisualizarMaterias = new ToolStripButton();
            btnGabarito = new ToolStripButton();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 569);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(914, 31);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(237, 25);
            statusLabelPrincipal.Text = "Visualizando 0 registro(s)...";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 35);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disciplinaMenuItem, materiaMenuItem });
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disciplinaMenuItem, questãoMenuItem });
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disciplinaMenuItem, materiaMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(109, 29);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // disciplinaMenuItem
            // 
            disciplinaMenuItem.Name = "disciplinaMenuItem";
            disciplinaMenuItem.Size = new Size(224, 30);
            disciplinaMenuItem.Text = "Disciplina";
            disciplinaMenuItem.Click += disciplinaMenuItem_Click;
            // 
            // materiaMenuItem
            // 
            materiaMenuItem.Name = "materiaMenuItem";
            materiaMenuItem.Size = new Size(143, 24);
            materiaMenuItem.Text = "Materia";
            materiaMenuItem.Click += materiaMenuItem_Click;
            // 
            // questãoMenuItem
            // 
            questãoMenuItem.Name = "questãoMenuItem";
            questãoMenuItem.Size = new Size(224, 30);
            questãoMenuItem.Text = "Questão";
            questãoMenuItem.Click += questaoMenuItem_Click;
            // 
            // materiaMenuItem
            // 
            materiaMenuItem.Name = "materiaMenuItem";
            materiaMenuItem.Size = new Size(143, 24);
            materiaMenuItem.Text = "Materia";
            materiaMenuItem.Click += materiaMenuItem_Click;
            // 
            // pnlRegistros
            // 
            pnlRegistros.Location = new Point(0, 85);
            pnlRegistros.Margin = new Padding(3, 4, 3, 4);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(944, 453);
            pnlRegistros.Size = new Size(800, 358);
            pnlRegistros.TabIndex = 7;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, btnFiltrar, toolStripSeparator3, btnVisualizarMaterias, toolStripSeparator2, btnPdf, btnDuplicaar, btnGabarito, toolStripSeparator4, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, btnFiltrar, toolStripSeparator3, btnAdicionarItens, toolStripSeparator2, btnVisualizarAlugueis, btnConcluirAluguel, btnConfigurarDescontos, toolStripSeparator4, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 35);
>>>>>>>>> Temporary merge branch 2
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 41);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Enabled = false;
            btnAdicionar.Image = Properties.Resources.btnAdicionar;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(5);
            btnAdicionar.Size = new Size(38, 38);
            btnAdicionar.Click += btnAdicionar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.btnEditar;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(38, 38);
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = Properties.Resources.btnExcluir;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(38, 38);
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 41);
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltrar.Enabled = false;
            btnFiltrar.Image = Properties.Resources.btnFiltrar;
            btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            btnFiltrar.Size = new Size(29, 38);
            btnFiltrar.Size = new Size(38, 38);
=========
            btnFiltrar.Size = new Size(29, 38);
>>>>>>>>> Temporary merge branch 2
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 41);
            // 
            // btnDuplicaar
            // 
            btnDuplicaar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDuplicaar.Enabled = false;
            btnDuplicaar.Image = Properties.Resources.library_add_FILL0_wght400_GRAD0_opsz24;
            btnDuplicaar.ImageScaling = ToolStripItemImageScaling.None;
            btnDuplicaar.ImageTransparentColor = Color.Magenta;
            btnDuplicaar.Name = "btnDuplicaar";
            btnDuplicaar.Padding = new Padding(5);
            btnDuplicaar.Size = new Size(38, 38);
=========
            btnAdicionarItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionarItens.Enabled = false;
            btnAdicionarItens.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionarItens.ImageTransparentColor = Color.Magenta;
            btnAdicionarItens.Name = "btnAdicionarItens";
            btnAdicionarItens.Padding = new Padding(5);
            btnAdicionarItens.Size = new Size(29, 38);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 41);
            // 
            // btnVisualizarAlugueis
            // 
            btnVisualizarAlugueis.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizarAlugueis.Enabled = false;
            btnVisualizarAlugueis.ImageScaling = ToolStripItemImageScaling.None;
            btnVisualizarAlugueis.ImageTransparentColor = Color.Magenta;
            btnVisualizarAlugueis.Name = "btnVisualizarAlugueis";
            btnVisualizarAlugueis.Padding = new Padding(5);
            btnVisualizarAlugueis.Size = new Size(29, 38);
            // 
            // btnConcluirAluguel
            // 
            btnConcluirAluguel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnConcluirAluguel.Enabled = false;
            btnConcluirAluguel.ImageScaling = ToolStripItemImageScaling.None;
            btnConcluirAluguel.ImageTransparentColor = Color.Magenta;
            btnConcluirAluguel.Name = "btnConcluirAluguel";
            btnConcluirAluguel.Padding = new Padding(5);
            btnConcluirAluguel.Size = new Size(29, 38);
            
>>>>>>>>> Temporary merge branch 2
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 41);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(123, 38);
            lblTipoCadastro.Text = "Tipo de Cadastro";
            // 
            // btnPdf
            // 
            btnPdf.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPdf.Enabled = false;
            btnPdf.Image = Properties.Resources.icons8_pdf_24;
            btnPdf.ImageScaling = ToolStripItemImageScaling.None;
            btnPdf.ImageTransparentColor = Color.Magenta;
            btnPdf.Name = "btnPdf";
            btnPdf.Padding = new Padding(5);
            btnPdf.Size = new Size(38, 38);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 41);
            // 
            // btnVisualizarMaterias
            // 
            btnVisualizarMaterias.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizarMaterias.Enabled = false;
            btnVisualizarMaterias.Image = Properties.Resources.btnVisualizarAlugueis;
            btnVisualizarMaterias.ImageScaling = ToolStripItemImageScaling.None;
            btnVisualizarMaterias.ImageTransparentColor = Color.Magenta;
            btnVisualizarMaterias.Name = "btnVisualizarMaterias";
            btnVisualizarMaterias.Padding = new Padding(5);
            btnVisualizarMaterias.Size = new Size(38, 38);
            // 
            // btnGabarito
            // 
            btnGabarito.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGabarito.Enabled = false;
            btnGabarito.Image = Properties.Resources.check_box_FILL0_wght400_GRAD0_opsz24;
            btnGabarito.ImageScaling = ToolStripItemImageScaling.None;
            btnGabarito.ImageTransparentColor = Color.Magenta;
            btnGabarito.Name = "btnGabarito";
            btnGabarito.Padding = new Padding(5);
            btnGabarito.Size = new Size(38, 38);
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(toolStrip1);
            Controls.Add(pnlRegistros);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "TelaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de Testes";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabelPrincipal;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem disciplinaMenuItem;
        private Panel pnlRegistros;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnFiltrar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem questãoMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripLabel lblTipoCadastro;
<<<<<<<<< Temporary merge branch 1
        private ToolStripMenuItem materiaMenuItem;
        private ToolStripButton btnVisualizarMaterias;
        private ToolStripMenuItem questãoMenuItem;
=========
        private ToolStripMenuItem questãoMenuItem;
>>>>>>>>> Temporary merge branch 2
    }
}
