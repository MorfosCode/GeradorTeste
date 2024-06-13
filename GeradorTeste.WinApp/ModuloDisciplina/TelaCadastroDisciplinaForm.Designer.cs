namespace GeradorTeste.WinForms.ModuloDisciplina
{
    partial class TelaCadastroDisciplinaForm
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
            txtDisciplina = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(319, 134);
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
            btnGravar.Location = new Point(238, 134);
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
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 32;
            label2.Text = "Disciplina:";
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
            // txtDisciplina
            // 
            txtDisciplina.Location = new Point(88, 79);
            txtDisciplina.Name = "txtDisciplina";
            txtDisciplina.Size = new Size(303, 23);
            txtDisciplina.TabIndex = 34;
            // 
            // TelaCadastroDisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 186);
            Controls.Add(txtDisciplina);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroDisciplinaForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Disciplina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDisciplina;
    }
}