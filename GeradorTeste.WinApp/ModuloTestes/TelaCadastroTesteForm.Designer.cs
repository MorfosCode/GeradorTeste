namespace GeradorTeste.WinApp.ModuloTestes
{
    partial class TelaCadastroTesteForm
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
            label2 = new Label();
            label3 = new Label();
            cmbDisciplina = new ComboBox();
            cmbMateria = new ComboBox();
            txtTitulo = new TextBox();
            domainUpDown1 = new DomainUpDown();
            cbRecuperacao = new CheckBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnSortea = new Button();
            listQuestoes = new ListBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 40);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 80);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Disciplina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 128);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Materia";
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Location = new Point(105, 72);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(149, 23);
            cmbDisciplina.TabIndex = 3;
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(105, 120);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(147, 23);
            cmbMateria.TabIndex = 4;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(105, 32);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(335, 23);
            txtTitulo.TabIndex = 5;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(379, 73);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(61, 23);
            domainUpDown1.TabIndex = 6;
            // 
            // cbRecuperacao
            // 
            cbRecuperacao.AutoSize = true;
            cbRecuperacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbRecuperacao.Location = new Point(277, 122);
            cbRecuperacao.Name = "cbRecuperacao";
            cbRecuperacao.Size = new Size(163, 21);
            cbRecuperacao.TabIndex = 7;
            cbRecuperacao.Text = " Prova de Recuperação";
            cbRecuperacao.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 80);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 8;
            label4.Text = "Qtd. Questões";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSortea);
            groupBox1.Location = new Point(105, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 74);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // btnSortea
            // 
            btnSortea.DialogResult = DialogResult.OK;
            btnSortea.Location = new Point(12, 24);
            btnSortea.Name = "btnSortea";
            btnSortea.Size = new Size(121, 32);
            btnSortea.TabIndex = 0;
            btnSortea.Text = "Sortear Questões";
            btnSortea.UseVisualStyleBackColor = true;
            // 
            // listQuestoes
            // 
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 15;
            listQuestoes.Location = new Point(105, 255);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(335, 169);
            listQuestoes.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(368, 466);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(72, 39);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(267, 466);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(72, 39);
            btnGravar.TabIndex = 42;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 523);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(listQuestoes);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(cbRecuperacao);
            Controls.Add(domainUpDown1);
            Controls.Add(txtTitulo);
            Controls.Add(cmbMateria);
            Controls.Add(cmbDisciplina);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TelaCadastroTesteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Teste";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbDisciplina;
        private ComboBox cmbMateria;
        private TextBox txtTitulo;
        private DomainUpDown domainUpDown1;
        private CheckBox cbRecuperacao;
        private Label label4;
        private GroupBox groupBox1;
        private Button btnSortea;
        private ListBox listQuestoes;
        private Button btnCancelar;
        private Button btnGravar;
    }
}