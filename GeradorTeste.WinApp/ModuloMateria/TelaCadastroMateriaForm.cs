using GeradorTeste.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GeradorTeste.WinApp.ModuloMateria
{
    public partial class TelaCadastroMateriaForm : Form
    {

        public Materia materia;

        public Materia Materia
        {

            get
            {
                return materia;
            }
            set
            {
                txtId.Text = value.Id.ToString();
                txtMateria.Text = value.NomeMateria;
                comboBoxDisciplina.SelectedItem = value.Disciplina;

                if (rdbPrimeira.Checked == true)
                {
                    value.Serie = "1ª";
                }
                if (rdbSegunda.Checked == true)
                {
                    value.Serie = "2ª";
                }

            }
        }

        private List<Materia> materiasCadastradas;
        public TelaCadastroMateriaForm(List<Disciplina> disciplinas, List<Materia> materiasCadastradas)
        {
            InitializeComponent();
            CarregarDisciplina(disciplinas);
            this.materiasCadastradas = materiasCadastradas;
        }

        private void CarregarDisciplina(List<Disciplina> disciplinas)
        {
           

            foreach (Disciplina disciplina in disciplinas)
                comboBoxDisciplina.Items.Add(disciplina);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtMateria.Text;
            Disciplina disciplina = (Disciplina)comboBoxDisciplina.SelectedItem;
            string serie = "";

            if (rdbPrimeira.Checked )
            {
                serie = "1ª";
            }
           else if (rdbSegunda.Checked)
            {
                serie = "2ª";
            }

            materia = new Materia(disciplina, nome, serie);

            List<string> erros = materia.Validar();

            if (MateriaTemNomeDuplicado())
                erros.Add("Já existe uma matéria com este nome cadastrada, tente utilizar outro!");

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

        }
        private bool MateriaTemNomeDuplicado()
        {
            return materiasCadastradas.Any(m => m.NomeMateria == materia.NomeMateria);
        }
    } 
    
}

