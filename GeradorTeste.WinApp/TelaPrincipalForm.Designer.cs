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
            questãoMenuItem = new ToolStripMenuItem();
            disciplinaMenuItem = new ToolStripMenuItem();
            materiaMenuItem = new ToolStripMenuItem();
            testeMenuIteste = new ToolStripMenuItem();
            questaoMenuItem = new ToolStripMenuItem();
            testeMenuItem = new ToolStripMenuItem();
            pnlRegistros = new Panel();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnVisualizarMaterias = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnPdf = new ToolStripButton();
            btnDuplicaar = new ToolStripButton();
            btnGabarito = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
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
            statusStrip1.Location = new Point(0, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 25);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(185, 20);
            statusLabelPrincipal.Text = "Visualizando 0 registro(s)...";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { questãoMenuItem, disciplinaMenuItem, materiaMenuItem, testeMenuIteste });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(86, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // questãoMenuItem
            // 
            questãoMenuItem.Name = "questãoMenuItem";
            questãoMenuItem.Size = new Size(180, 24);
            questãoMenuItem.Text = "Questão";
            questãoMenuItem.Click += questaoMenuItem_Click;
            // 
            // disciplinaMenuItem
            // 
            disciplinaMenuItem.Name = "disciplinaMenuItem";
            disciplinaMenuItem.Size = new Size(180, 24);
            disciplinaMenuItem.Text = "Disciplina";
            disciplinaMenuItem.Click += disciplinaMenuItem_Click;
            // 
            // materiaMenuItem
            // 
            materiaMenuItem.Name = "materiaMenuItem";
            materiaMenuItem.Size = new Size(180, 24);
            materiaMenuItem.Text = "Materia";
            materiaMenuItem.Click += materiaMenuItem_Click;
            // 
            // testeMenuIteste
            // 
            testeMenuIteste.Name = "testeMenuIteste";
            testeMenuIteste.Size = new Size(180, 24);
            testeMenuIteste.Text = "Teste";
            testeMenuIteste.Click += testeMenuIteste_Click;
            // 
            // questaoMenuItem
            // 
            questaoMenuItem.Name = "questaoMenuItem";
            questaoMenuItem.Size = new Size(180, 30);
            questaoMenuItem.Text = "Questão";
            questaoMenuItem.Click += questaoMenuItem_Click_1;
            // 
            // testeMenuItem
            // 
            testeMenuItem.Name = "testeMenuItem";
            testeMenuItem.Size = new Size(180, 30);
            testeMenuItem.Text = "Teste";
            testeMenuItem.Click += testeMenuItem_Click;
            // 
            // pnlRegistros
            // 
            pnlRegistros.Location = new Point(0, 60);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(800, 367);
            pnlRegistros.TabIndex = 7;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, btnFiltrar, toolStripSeparator3, btnVisualizarMaterias, toolStripSeparator2, btnPdf, btnDuplicaar, btnGabarito, toolStripSeparator4, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 41);
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
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(5);
            btnFiltrar.Size = new Size(38, 38);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 41);
            // 
            // btnVisualizarMaterias
            // 
            btnVisualizarMaterias.Name = "btnVisualizarMaterias";
            btnVisualizarMaterias.Size = new Size(23, 38);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 41);
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
            btnPdf.Click += btnPdf_Click;
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
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(pnlRegistros);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
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
        private ToolStripButton btnDuplicaar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripLabel lblTipoCadastro;
        private ToolStripMenuItem questãoMenuItem;
        private ToolStripMenuItem materiaMenuItem;
        private ToolStripButton btnVisualizarMaterias;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnPdf;
        private ToolStripButton btnGabarito;
        private ToolStripMenuItem questaoMenuItem;
        private ToolStripMenuItem testeMenuItem;
        private ToolStripMenuItem testeMenuIteste;
    }
}
