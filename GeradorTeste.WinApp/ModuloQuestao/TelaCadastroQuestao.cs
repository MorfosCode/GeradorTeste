using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeradorTeste.ModuloDisciplina;
using GeradorTeste.WinApp.ModuloDisciplina;
using GeradorTeste.WinApp.ModuloMateria;

namespace GeradorTeste.WinApp.ModuloQuestao
{
    public partial class TelaCadastroQuestao : Form
    {
        IRepositorioMateria repositorioMateria;
        IRepositorioDisciplina repositorioDisciplina;

        public List<Materia> listaMateria = new List<Materia>();

        private Questao questao;

        public Questao Questao
        {
            get
            {
                return questao;
            }
            set
            {
                comboBoxMaterias.Text = value.Materia.NomeMateria + ", " + value.Materia.Serie;
                textBoxId.Text = value.Id.ToString();
                textBoxEnunciado.Text = value.Enunciado;
                string alternativaCorreta = value.AlternativaCorreta;

                foreach (string alternativa in value.Alternativas)
                {
                    string opcao = alternativa;

                    if (alternativa == alternativaCorreta)
                        checkedListBoxRespostas.Items.Add(alternativa, true);

                    else
                        checkedListBoxRespostas.Items.Add(alternativa, false);
                }
            }
        }

        #region Construtor de classe
        public TelaCadastroQuestao()
        {
            InitializeComponent();

            repositorioMateria = new RepositorioMateriaEmArquivo();
            listaMateria = repositorioMateria.SelecionarTodos();

            //Cadastra materias para possibilitar os testes
            CadastrarMaterias();

            CarregarMaterias();
        }
        #endregion

        #region Carrega matérias no componente comboBoxMaterias
        private void CarregarMaterias()
        {
            comboBoxMaterias.Items.Clear();
            foreach (Materia materia in listaMateria)
            {
                comboBoxMaterias.Items.Add(materia.NomeMateria + ", " + materia.Serie);
            }
        }
        #endregion

        #region Cadastra matérias para auxiliar nos testes
        private void CadastrarMaterias()
        {
            //Disciplina matematica = new Disciplina();
            //matematica.Nome = "MATEMÁTICA";

            //Disciplina linguaPortugesa = new Disciplina();
            //linguaPortugesa.Nome = "LÍNGUA PORTUGUESA";

            //List<Materia> materias = new List<Materia>()
            //{
            //    new Materia(matematica, "Adição", "1º Série"),
            //    new Materia(matematica, "Subtração", "1º Série"),
            //    new Materia(linguaPortugesa, "Alfabeto", "2º Série")
            //};

            //repositorioMateria.CadastrarVarios(materias);
        }
        #endregion

        #region Eventos de botões
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (textBoxResposta.Text != "")
            {
                checkedListBoxRespostas.Items.Add(textBoxResposta.Text);
                textBoxResposta.Clear();
                textBoxResposta.Focus();
            }
            else
                MessageBox.Show("Por favor digite uma resposta!");
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            checkedListBoxRespostas.Items.Remove(checkedListBoxRespostas.SelectedItem);
        }

        private void buttonLimparCheckedList_Click(object sender, EventArgs e)
        {
            checkedListBoxRespostas.Items.Clear();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            ValidarCampos();

            Materia materia = new Materia();

            int indexSelecionadoNoCombo = comboBoxMaterias.SelectedIndex;

            materia = listaMateria.ElementAt(indexSelecionadoNoCombo);

            string enunciado = textBoxEnunciado.Text;

            List<string> alternativas = new List<string>();

            foreach (string alternativa in checkedListBoxRespostas.Items)
            {
                alternativas.Add(alternativa);
            }

            string alternativaCorreta = "";

            foreach (string alternativa in checkedListBoxRespostas.CheckedItems)
            {
                alternativaCorreta = alternativa;
            }

            questao = new Questao(materia, enunciado, alternativas, alternativaCorreta);

            List<string> erros = questao.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

        }
        #endregion

        #region Valida campos
        private void ValidarCampos()
        {
            if (comboBoxMaterias.SelectedIndex < 0)
            {
                MessageBox.Show("Uma \"MATÉRIA\" precisa ser selecionada!");
                comboBoxMaterias.Focus();
                return;
            }

            if (textBoxEnunciado.Text == "")
            {
                MessageBox.Show("Precisa ter um \"ENUNCIADO\"!");
                textBoxEnunciado.Focus();
                return;
            }

            if (checkedListBoxRespostas.Items.Count < 2)
            {
                MessageBox.Show("Precisa ter pelo menos duas alternativas!");
                checkedListBoxRespostas.Focus();
                return;
            }

            if (checkedListBoxRespostas.CheckedItems.Count > 1)
            {
                MessageBox.Show("Precisa somente de uma alternativa correta!");
                checkedListBoxRespostas.Focus();
                return;
            }

            if (checkedListBoxRespostas.CheckedItems.Count < 1)
            {
                MessageBox.Show("Precisa ter uma alternativa correta!");
                checkedListBoxRespostas.Focus();
                return;
            }
        }
        #endregion

        #region Eventos de checkedListBoxRespostas
        private void checkedListBoxRespostas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelecionado = checkedListBoxRespostas.SelectedIndex;
            int itensSelecionados = checkedListBoxRespostas.Items.Count;

            if (itensSelecionados > 1)
            {
                if (indexSelecionado > 0)
                {
                    for (int i = 0; i < indexSelecionado; i++)
                        checkedListBoxRespostas.SetItemChecked(i, false);

                    for (int i = indexSelecionado + 1; i < itensSelecionados; i++)
                        checkedListBoxRespostas.SetItemChecked(i, false);
                }
                else if (indexSelecionado == 0)
                {
                    for (int i = 1; i < itensSelecionados; i++)
                        checkedListBoxRespostas.SetItemChecked(i, false);
                }
            }
        }
        #endregion
    }
}
