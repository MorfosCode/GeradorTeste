namespace GeradorTeste.WinApp.ModuloTestes.ModuloPDF
{
    partial class TelaPdfForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnGerarPdf = new Button();
            labelMateria = new Label();
            labelDisciplina = new Label();
            labelTitulo = new Label();
            groupBox1 = new GroupBox();
            listQuestoes = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNomeArquivo = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Arquivo:";
            // 
            // btnGerarPdf
            // 
            btnGerarPdf.DialogResult = DialogResult.OK;
            btnGerarPdf.Location = new Point(302, 481);
            btnGerarPdf.Name = "btnGerarPdf";
            btnGerarPdf.Size = new Size(112, 28);
            btnGerarPdf.TabIndex = 2;
            btnGerarPdf.Text = "Gerar PDF";
            btnGerarPdf.UseVisualStyleBackColor = true;
            btnGerarPdf.Click += btnGerarPdf_Click;
            // 
            // labelMateria
            // 
            labelMateria.AutoSize = true;
            labelMateria.Location = new Point(80, 138);
            labelMateria.Name = "labelMateria";
            labelMateria.Size = new Size(47, 15);
            labelMateria.TabIndex = 65;
            labelMateria.Text = "materia";
            // 
            // labelDisciplina
            // 
            labelDisciplina.AutoSize = true;
            labelDisciplina.Location = new Point(79, 97);
            labelDisciplina.Name = "labelDisciplina";
            labelDisciplina.Size = new Size(57, 15);
            labelDisciplina.TabIndex = 64;
            labelDisciplina.Text = "disciplina";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(81, 62);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(35, 15);
            labelTitulo.TabIndex = 63;
            labelTitulo.Text = "titulo";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listQuestoes);
            groupBox1.Location = new Point(79, 181);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 294);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // listQuestoes
            // 
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 15;
            listQuestoes.Location = new Point(6, 28);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(323, 259);
            listQuestoes.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 137);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 61;
            label3.Text = "Materia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 96);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 60;
            label4.Text = "Disciplina";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 61);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 59;
            label5.Text = "Titulo";
            // 
            // txtNomeArquivo
            // 
            txtNomeArquivo.Location = new Point(81, 22);
            txtNomeArquivo.Name = "txtNomeArquivo";
            txtNomeArquivo.Size = new Size(327, 23);
            txtNomeArquivo.TabIndex = 66;
            // 
            // TelaPdfFormcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 521);
            Controls.Add(txtNomeArquivo);
            Controls.Add(labelMateria);
            Controls.Add(labelDisciplina);
            Controls.Add(labelTitulo);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(btnGerarPdf);
            Controls.Add(label1);
            Enabled = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "TelaPdfFormcs";
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerar Pdf";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGerarPdf;
        private Label labelMateria;
        private Label labelDisciplina;
        private Label labelTitulo;
        private GroupBox groupBox1;
        private ListBox listQuestoes;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNomeArquivo;
    }
}