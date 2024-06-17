namespace GeradorTeste.WinApp.ModuloCadastrarQuestao
{
    partial class TelaCadastroQuestao
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
            labelMateria = new Label();
            labelEnunciado = new Label();
            labelResposta = new Label();
            comboBoxMaterias = new ComboBox();
            groupBoxRespostas = new GroupBox();
            buttonLimparCheckedList = new Button();
            checkedListBoxRespostas = new CheckedListBox();
            buttonRemover = new Button();
            textBoxEnunciado = new TextBox();
            textBoxResposta = new TextBox();
            buttonAdicionar = new Button();
            buttonCancelar = new Button();
            buttonGravar = new Button();
            textBoxId = new TextBox();
            labelId = new Label();
            groupBoxRespostas.SuspendLayout();
            SuspendLayout();
            // 
            // labelMateria
            // 
            labelMateria.AutoSize = true;
            labelMateria.Location = new Point(30, 26);
            labelMateria.Name = "labelMateria";
            labelMateria.Size = new Size(63, 20);
            labelMateria.TabIndex = 0;
            labelMateria.Text = "Matéria:";
            // 
            // labelEnunciado
            // 
            labelEnunciado.AutoSize = true;
            labelEnunciado.Location = new Point(12, 68);
            labelEnunciado.Name = "labelEnunciado";
            labelEnunciado.Size = new Size(81, 20);
            labelEnunciado.TabIndex = 0;
            labelEnunciado.Text = "Enunciado:";
            // 
            // labelResposta
            // 
            labelResposta.AutoSize = true;
            labelResposta.Location = new Point(21, 194);
            labelResposta.Name = "labelResposta";
            labelResposta.Size = new Size(72, 20);
            labelResposta.TabIndex = 0;
            labelResposta.Text = "Resposta:";
            // 
            // comboBoxMaterias
            // 
            comboBoxMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaterias.FormattingEnabled = true;
            comboBoxMaterias.Location = new Point(99, 22);
            comboBoxMaterias.Name = "comboBoxMaterias";
            comboBoxMaterias.Size = new Size(275, 28);
            comboBoxMaterias.Sorted = true;
            comboBoxMaterias.TabIndex = 0;
            // 
            // groupBoxRespostas
            // 
            groupBoxRespostas.Controls.Add(buttonLimparCheckedList);
            groupBoxRespostas.Controls.Add(checkedListBoxRespostas);
            groupBoxRespostas.Controls.Add(buttonRemover);
            groupBoxRespostas.Location = new Point(12, 244);
            groupBoxRespostas.Name = "groupBoxRespostas";
            groupBoxRespostas.Size = new Size(687, 274);
            groupBoxRespostas.TabIndex = 4;
            groupBoxRespostas.TabStop = false;
            groupBoxRespostas.Text = "Respostas:";
            // 
            // buttonLimparCheckedList
            // 
            buttonLimparCheckedList.Location = new Point(109, 26);
            buttonLimparCheckedList.Name = "buttonLimparCheckedList";
            buttonLimparCheckedList.Size = new Size(94, 29);
            buttonLimparCheckedList.TabIndex = 7;
            buttonLimparCheckedList.Text = "Limpar";
            buttonLimparCheckedList.UseVisualStyleBackColor = true;
            buttonLimparCheckedList.Click += buttonLimparCheckedList_Click;
            // 
            // checkedListBoxRespostas
            // 
            checkedListBoxRespostas.CheckOnClick = true;
            checkedListBoxRespostas.FormattingEnabled = true;
            checkedListBoxRespostas.Location = new Point(9, 61);
            checkedListBoxRespostas.Name = "checkedListBoxRespostas";
            checkedListBoxRespostas.Size = new Size(672, 202);
            checkedListBoxRespostas.TabIndex = 6;
            checkedListBoxRespostas.SelectedIndexChanged += checkedListBoxRespostas_SelectedIndexChanged;
            // 
            // buttonRemover
            // 
            buttonRemover.Location = new Point(9, 29);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(94, 29);
            buttonRemover.TabIndex = 5;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // textBoxEnunciado
            // 
            textBoxEnunciado.Location = new Point(99, 65);
            textBoxEnunciado.Multiline = true;
            textBoxEnunciado.Name = "textBoxEnunciado";
            textBoxEnunciado.Size = new Size(600, 108);
            textBoxEnunciado.TabIndex = 1;
            // 
            // textBoxResposta
            // 
            textBoxResposta.Location = new Point(99, 191);
            textBoxResposta.Name = "textBoxResposta";
            textBoxResposta.Size = new Size(485, 27);
            textBoxResposta.TabIndex = 2;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(605, 191);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(94, 29);
            buttonAdicionar.TabIndex = 3;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.DialogResult = DialogResult.Cancel;
            buttonCancelar.Location = new Point(605, 524);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonGravar
            // 
            buttonGravar.DialogResult = DialogResult.OK;
            buttonGravar.Location = new Point(505, 524);
            buttonGravar.Name = "buttonGravar";
            buttonGravar.Size = new Size(94, 29);
            buttonGravar.TabIndex = 5;
            buttonGravar.Text = "Gravar";
            buttonGravar.UseVisualStyleBackColor = true;
            buttonGravar.Click += buttonGravar_Click;
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Location = new Point(599, 23);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 27);
            textBoxId.TabIndex = 2;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(571, 26);
            labelId.Name = "labelId";
            labelId.Size = new Size(27, 20);
            labelId.TabIndex = 0;
            labelId.Text = "ID:";
            // 
            // TelaCadastroQuestao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 565);
            Controls.Add(buttonGravar);
            Controls.Add(buttonCancelar);
            Controls.Add(textBoxId);
            Controls.Add(buttonAdicionar);
            Controls.Add(textBoxResposta);
            Controls.Add(textBoxEnunciado);
            Controls.Add(groupBoxRespostas);
            Controls.Add(comboBoxMaterias);
            Controls.Add(labelResposta);
            Controls.Add(labelEnunciado);
            Controls.Add(labelId);
            Controls.Add(labelMateria);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroQuestao";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Questões";
            groupBoxRespostas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMateria;
        private Label labelEnunciado;
        private Label labelResposta;
        private ComboBox comboBoxMaterias;
        private GroupBox groupBoxRespostas;
        private TextBox textBoxEnunciado;
        private TextBox textBoxResposta;
        private Button buttonAdicionar;
        private Button buttonRemover;
        private Button buttonCancelar;
        private Button buttonGravar;
        private CheckedListBox checkedListBoxRespostas;
        private TextBox textBoxId;
        private Label labelId;
        private Button buttonLimparCheckedList;
    }
}