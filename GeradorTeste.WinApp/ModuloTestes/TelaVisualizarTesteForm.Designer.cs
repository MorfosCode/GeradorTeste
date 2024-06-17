namespace GeradorTeste.WinApp.ModuloTestes
{
    partial class TelaVisualizarTesteForm
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
            btnFechar = new Button();
            listQuestoes = new ListBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelTitulo = new Label();
            labelDisciplina = new Label();
            labelMateria = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.DialogResult = DialogResult.Cancel;
            btnFechar.Location = new Point(289, 463);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(72, 39);
            btnFechar.TabIndex = 55;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // listQuestoes
            // 
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 15;
            listQuestoes.Location = new Point(6, 22);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(323, 229);
            listQuestoes.TabIndex = 45;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listQuestoes);
            groupBox1.Location = new Point(32, 168);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 263);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 108);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 47;
            label3.Text = "Materia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 67);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 46;
            label2.Text = "Disciplina";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 32);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 44;
            label1.Text = "Titulo";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(91, 33);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(35, 15);
            labelTitulo.TabIndex = 56;
            labelTitulo.Text = "titulo";
            // 
            // labelDisciplina
            // 
            labelDisciplina.AutoSize = true;
            labelDisciplina.Location = new Point(89, 68);
            labelDisciplina.Name = "labelDisciplina";
            labelDisciplina.Size = new Size(57, 15);
            labelDisciplina.TabIndex = 57;
            labelDisciplina.Text = "disciplina";
            // 
            // labelMateria
            // 
            labelMateria.AutoSize = true;
            labelMateria.Location = new Point(90, 109);
            labelMateria.Name = "labelMateria";
            labelMateria.Size = new Size(47, 15);
            labelMateria.TabIndex = 58;
            labelMateria.Text = "materia";
            // 
            // TelaVisualizarTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 514);
            Controls.Add(labelMateria);
            Controls.Add(labelDisciplina);
            Controls.Add(labelTitulo);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TelaVisualizarTesteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizacão de Teste";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFechar;
        private ListBox listQuestoes;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label labelTitulo;
        private Label labelDisciplina;
        private Label labelMateria;
    }
}