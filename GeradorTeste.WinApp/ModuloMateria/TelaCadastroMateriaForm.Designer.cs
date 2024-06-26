namespace GeradorTeste.WinApp.ModuloMateria
{
    partial class TelaCadastroMateriaForm
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
            label4 = new Label();
            comboBoxDisciplina = new ComboBox();
            label3 = new Label();
            rdbSegunda = new RadioButton();
            rdbPrimeira = new RadioButton();
            txtMateria = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 185);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 50;
            label4.Text = "Série:";
            // 
            // comboBoxDisciplina
            // 
            comboBoxDisciplina.FormattingEnabled = true;
            comboBoxDisciplina.Location = new Point(90, 130);
            comboBoxDisciplina.Name = "comboBoxDisciplina";
            comboBoxDisciplina.Size = new Size(121, 23);
            comboBoxDisciplina.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 138);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 48;
            label3.Text = "Disciplina:";
            // 
            // rdbSegunda
            // 
            rdbSegunda.AutoSize = true;
            rdbSegunda.Location = new Point(148, 185);
            rdbSegunda.Name = "rdbSegunda";
            rdbSegunda.Size = new Size(36, 19);
            rdbSegunda.TabIndex = 47;
            rdbSegunda.TabStop = true;
            rdbSegunda.Text = "2º";
            // 
            // rdbPrimeira
            // 
            rdbPrimeira.AutoSize = true;
            rdbPrimeira.Location = new Point(90, 183);
            rdbPrimeira.Name = "rdbPrimeira";
            rdbPrimeira.Size = new Size(36, 19);
            rdbPrimeira.TabIndex = 46;
            rdbPrimeira.TabStop = true;
            rdbPrimeira.Text = "1º";
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(90, 84);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(303, 23);
            txtMateria.TabIndex = 45;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(90, 38);
            txtId.Name = "txtId";
            txtId.ShortcutsEnabled = false;
            txtId.Size = new Size(49, 23);
            txtId.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 87);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 43;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 38);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 42;
            label1.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(321, 235);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(72, 39);
            btnCancelar.TabIndex = 41;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(220, 235);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(72, 39);
            btnGravar.TabIndex = 40;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // TelaCadastroMateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 302);
            Controls.Add(label4);
            Controls.Add(comboBoxDisciplina);
            Controls.Add(label3);
            Controls.Add(rdbSegunda);
            Controls.Add(rdbPrimeira);
            Controls.Add(txtMateria);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "TelaCadastroMateriaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Materia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox comboBoxDisciplina;
        private Label label3;
        private RadioButton rdbSegunda;
        private RadioButton rdbPrimeira;
        private TextBox txtMateria;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
    }
}