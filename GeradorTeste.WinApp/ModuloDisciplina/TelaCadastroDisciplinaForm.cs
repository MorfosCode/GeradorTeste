
using GeradorTeste.WinApp;
using GeradorTeste.ModuloDisciplina;
using GeradorTeste.WinApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeradorTeste.WinForms.ModuloDisciplina
{
    public partial class TelaCadastroQuestao : Form
    {
        private Disciplina disciplina;
        

        public Disciplina Disciplina
        {

            get { return disciplina; }
            set
            {
               

                txtId.Text =value.Id.ToString();
                txtDisciplina.Text = value.Nome;

            }
        }

        private  List<Disciplina>  disciplinaCadatradas;
        
        public TelaCadastroQuestao(List<Disciplina> diciplinaCdastradas)
        {
            InitializeComponent();

            this.disciplinaCadatradas = diciplinaCdastradas;
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtDisciplina.Text;



            disciplina = new Disciplina(nome);

            List<string> erros = disciplina.Validar();
         
            DisciplinaDuplicada(erros);

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void DisciplinaDuplicada(List<string> erros)
        {
            if (disciplinaCadatradas.Any(d => d.Nome == disciplina.Nome))
            {

                erros.Add("Já existe uma diciplina com esse nome cadastrada! Tente novamente.");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

    }
}
