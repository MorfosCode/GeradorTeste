namespace GeradorTeste.WinForms.ModuloDisciplina
{
    partial class TelaCadastroDisplinaForm
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
            btnCancelar = new Button();
            btnGravar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtMateria = new TextBox();
            rdbPrimeira = new RadioButton();
            rdbSegunda = new RadioButton();
            label3 = new Label();
            comboBoxDisciplina = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(319, 230);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(72, 39);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(218, 230);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(72, 39);
            btnGravar.TabIndex = 29;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 33);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 31;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 82);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 32;
            label2.Text = "Nome:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(88, 33);
            txtId.Name = "txtId";
            txtId.ShortcutsEnabled = false;
            txtId.Size = new Size(49, 23);
            txtId.TabIndex = 33;
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(88, 79);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(303, 23);
            txtMateria.TabIndex = 34;
            // 
            // rdbPrimeira
            // 
            rdbPrimeira.AutoSize = true;
            rdbPrimeira.Location = new Point(88, 178);
            rdbPrimeira.Name = "rdbPrimeira";
            rdbPrimeira.Size = new Size(36, 19);
            rdbPrimeira.TabIndex = 35;
            rdbPrimeira.TabStop = true;
            rdbPrimeira.Text = "1º";
            rdbPrimeira.UseVisualStyleBackColor = true;
            // 
            // rdbSegunda
            // 
            rdbSegunda.AutoSize = true;
            rdbSegunda.Location = new Point(146, 180);
            rdbSegunda.Name = "rdbSegunda";
            rdbSegunda.Size = new Size(36, 19);
            rdbSegunda.TabIndex = 36;
            rdbSegunda.TabStop = true;
            rdbSegunda.Text = "2º";
            rdbSegunda.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 37;
            label3.Text = "Disciplina:";
            // 
            // comboBoxDisciplina
            // 
            comboBoxDisciplina.FormattingEnabled = true;
            comboBoxDisciplina.Location = new Point(88, 125);
            comboBoxDisciplina.Name = "comboBoxDisciplina";
            comboBoxDisciplina.Size = new Size(121, 23);
            comboBoxDisciplina.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 180);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 39;
            label4.Text = "Série:";
            // 
            // TelaCadastroDisplinaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 294);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroDisplinaForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro Materia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtMateria;
        private RadioButton rdbPrimeira;
        private RadioButton rdbSegunda;
        private Label label3;
        private ComboBox comboBoxDisciplina;
        private Label label4;
    }
}