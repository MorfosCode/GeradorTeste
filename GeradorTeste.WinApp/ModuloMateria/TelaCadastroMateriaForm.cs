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


        public TelaCadastroMateriaForm(List<Disciplina> disciplinas)
        {
            InitializeComponent();
            CarregarDisciplina(disciplinas);
        }

        private void CarregarDisciplina(List<Disciplina> disciplinas)
        {
            comboBoxDisciplina.Items.Clear();

            foreach (Disciplina disciplina in disciplinas)
                comboBoxDisciplina.Items.Add(disciplina);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtMateria.Text;
            Disciplina disciplina = (Disciplina)comboBoxDisciplina.SelectedItem;
            string serie = "";

            if (rdbPrimeira.Checked == true)
            {
                serie = "1ª";
            }
            if (rdbSegunda.Checked == true)
            {
                serie = "2ª";
            }



            materia = new Materia(nome, disciplina, serie);

            List<string> erros = materia.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

        }

        private void rdbPrimeira_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPrimeira.Checked == true)
                rdbSegunda.Checked = false;
            else
                rdbSegunda.Checked = true;
        }

        private void rdbSegunda_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbSegunda.Checked == true)
                rdbPrimeira.Checked = false;
            else
                rdbPrimeira.Checked = true;
        }
    } 
    
}

