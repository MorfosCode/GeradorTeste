
using GeradorTeste.WinApp;
using GeradorTeste.ModuloDisciplina;
using GeradorTeste.WinApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeradorTeste.WinForms.ModuloDisciplina
{
    public partial class TelaCadastroDisplinaForm : Form
    {
        public TelaCadastroDisplinaForm()
        {
            InitializeComponent();
        }
        private Disciplina disciplina;


        public Disciplina Disciplina
        {

            get { return disciplina; }
            set
            {
               

                txtId.Text =value.Id.ToString();
                txtMateria.Text = value.Nome;

            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
           string nome = txtMateria.Text;



            disciplina = new Disciplina(nome);

            List<string> erros = disciplina.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
      

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

    }
}
