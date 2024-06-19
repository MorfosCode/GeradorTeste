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
            domainUpDownQuantidadeDeQuestoes = new DomainUpDown();
            cbRecuperacao = new CheckBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnSortear = new Button();
            listQuestoes = new ListBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            textBoxId = new TextBox();
            label5 = new Label();
            radioButton1Serie = new RadioButton();
            radioButton2Serie = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 16);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Disciplina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 152);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Materia";
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Location = new Point(89, 103);
            cmbDisciplina.Margin = new Padding(3, 4, 3, 4);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(221, 28);
            cmbDisciplina.TabIndex = 1;
            cmbDisciplina.SelectedIndexChanged += cmbDisciplina_SelectedIndexChanged;
            // 
            // cmbMateria
            // 
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(89, 148);
            cmbMateria.Margin = new Padding(3, 4, 3, 4);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(221, 28);
            cmbMateria.TabIndex = 3;
            cmbMateria.SelectedIndexChanged += cmbMateria_SelectedIndexChanged;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(89, 58);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(382, 27);
            txtTitulo.TabIndex = 0;
            // 
            // domainUpDownQuantidadeDeQuestoes
            // 
            domainUpDownQuantidadeDeQuestoes.Location = new Point(391, 104);
            domainUpDownQuantidadeDeQuestoes.Margin = new Padding(3, 4, 3, 4);
            domainUpDownQuantidadeDeQuestoes.Name = "domainUpDownQuantidadeDeQuestoes";
            domainUpDownQuantidadeDeQuestoes.Size = new Size(80, 27);
            domainUpDownQuantidadeDeQuestoes.TabIndex = 2;
            domainUpDownQuantidadeDeQuestoes.KeyPress += domainUpDownQuantidadeDeQuestoes_KeyPress;
            // 
            // cbRecuperacao
            // 
            cbRecuperacao.AutoSize = true;
            cbRecuperacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbRecuperacao.Location = new Point(341, 148);
            cbRecuperacao.Margin = new Padding(3, 4, 3, 4);
            cbRecuperacao.Name = "cbRecuperacao";
            cbRecuperacao.Size = new Size(130, 27);
            cbRecuperacao.TabIndex = 4;
            cbRecuperacao.Text = "Recuperação";
            cbRecuperacao.UseVisualStyleBackColor = true;
            cbRecuperacao.CheckedChanged += cbRecuperacao_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 107);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 8;
            label4.Text = "Questões:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSortear);
            groupBox1.Controls.Add(listQuestoes);
            groupBox1.Location = new Point(12, 195);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(459, 316);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // btnSortear
            // 
            btnSortear.Enabled = false;
            btnSortear.Location = new Point(6, 27);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(140, 29);
            btnSortear.TabIndex = 5;
            btnSortear.Text = "Sortear Questões";
            btnSortear.UseVisualStyleBackColor = true;
            btnSortear.Click += btnSortear_Click;
            // 
            // listQuestoes
            // 
            listQuestoes.FormattingEnabled = true;
            listQuestoes.Location = new Point(6, 63);
            listQuestoes.Margin = new Padding(3, 4, 3, 4);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(447, 244);
            listQuestoes.TabIndex = 100;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(389, 519);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 29);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(301, 519);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(82, 29);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Location = new Point(89, 13);
            textBoxId.Margin = new Padding(3, 4, 3, 4);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 27);
            textBoxId.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 61);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 1;
            label5.Text = "Título:";
            // 
            // radioButton1Serie
            // 
            radioButton1Serie.AutoSize = true;
            radioButton1Serie.Checked = true;
            radioButton1Serie.Location = new Point(301, 14);
            radioButton1Serie.Name = "radioButton1Serie";
            radioButton1Serie.Size = new Size(81, 24);
            radioButton1Serie.TabIndex = 10;
            radioButton1Serie.TabStop = true;
            radioButton1Serie.Text = "1º Série";
            radioButton1Serie.UseVisualStyleBackColor = true;
            radioButton1Serie.CheckedChanged += radioButton1Serie_CheckedChanged;
            // 
            // radioButton2Serie
            // 
            radioButton2Serie.AutoSize = true;
            radioButton2Serie.Location = new Point(390, 14);
            radioButton2Serie.Name = "radioButton2Serie";
            radioButton2Serie.Size = new Size(81, 24);
            radioButton2Serie.TabIndex = 11;
            radioButton2Serie.Text = "2º Série";
            radioButton2Serie.UseVisualStyleBackColor = true;
            radioButton2Serie.CheckedChanged += radioButton2Serie_CheckedChanged;
            // 
            // TelaCadastroTesteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 557);
            Controls.Add(radioButton2Serie);
            Controls.Add(radioButton1Serie);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(cbRecuperacao);
            Controls.Add(domainUpDownQuantidadeDeQuestoes);
            Controls.Add(textBoxId);
            Controls.Add(txtTitulo);
            Controls.Add(cmbMateria);
            Controls.Add(cmbDisciplina);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
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
        private DomainUpDown domainUpDownQuantidadeDeQuestoes;
        private CheckBox cbRecuperacao;
        private Label label4;
        private GroupBox groupBox1;
        private ListBox listQuestoes;
        private Button btnCancelar;
        private Button btnGravar;
        private TextBox textBoxId;
        private Label label5;
        private Button btnSortear;
        private RadioButton radioButton1Serie;
        private RadioButton radioButton2Serie;
    }
}