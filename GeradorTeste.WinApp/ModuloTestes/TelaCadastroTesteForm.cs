using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeradorTeste.ModuloDisciplina;
using GeradorTeste.WinApp.ModuloQuestao;
using GeradorTeste.WinApp.ModuloDisciplina;
using GeradorTeste.WinApp.ModuloMateria;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GeradorTeste.WinApp.ModuloTestes
{
    public partial class TelaCadastroTesteForm : Form
    {
        IRepositorioDisciplina repositorioDisciplina;
        IRepositorioMateria repositorioMateria;
        IRepositorioQuestao repositorioQuestao;
        IRepositorioTeste repositorioTeste;

        private Teste teste;

        public Teste Teste
        {
            get
            {
                return teste;
            }
            set
            {
                textBoxId.Text = value.ToString();
                txtTitulo.Text = value.Titulo;
                cmbDisciplina.Text = value.Disciplina.Nome;
                cmbMateria.Text = value.Materia.NomeMateria + ", " + value.Materia.Serie;
                domainUpDownQuantidadeDeQuestoes.Text = value.QuantidadeQuestoes.ToString();

                if (value.Recuperacao == true)
                    cbRecuperacao.Checked = true;
                else
                    cbRecuperacao.Checked = false;

                listQuestoes.Items.AddRange(value.Questoes.ToArray());
            }
        }

        #region Construtor de classe
        public TelaCadastroTesteForm()
        {
            InitializeComponent();

            repositorioDisciplina = new RepositorioDisciplinaEmArquivos();
            repositorioMateria = new RepositorioMateriaEmArquivo();
            repositorioQuestao = new RepositorioQuestaoEmArquivo();
            repositorioTeste = new RepositorioTesteEmArquivo();

            CarregarDisciplinas();
        }
        #endregion

        #region Carrega as disciplinas no comboBoxDisciplinas
        private void CarregarDisciplinas()
        {
            cmbDisciplina.Items.Clear();

            foreach (GeradorTeste.ModuloDisciplina.Disciplina disciplina in repositorioDisciplina.SelecionarTodos())
                cmbDisciplina.Items.Add(disciplina);

            cmbMateria.DisplayMember = "Nome";
        }
        #endregion

        #region Carrega as matéria no comboBoxMaterias de acordo com a disciplina, levando em consideração a série
        private void CarregarMateriasPrimeiraSerie()
        {
            cmbMateria.Items.Clear();
            cmbMateria.Text = "";
            listQuestoes.Items.Clear();
            domainUpDownQuantidadeDeQuestoes.Items.Clear();
            cbRecuperacao.Checked = false;

            List<Materia> materiaPrimeiraSerie = new List<Materia>();

            foreach (Materia materia in repositorioMateria.SelecionarTodos())
            {
                if (materia.Serie == "1ª")
                    materiaPrimeiraSerie.Add(materia);
            }

            foreach (Materia materia in materiaPrimeiraSerie)
            {
                if (materia.Disciplina.Nome == cmbDisciplina.Text)
                    cmbMateria.Items.Add(materia);
            }
            cmbMateria.DisplayMember = "NomeMateria";
        }
        #endregion

        #region Carrega as matéria no comboBoxMaterias de acordo com a disciplina, levando em consideração a série
        private void CarregarMateriasSegundaSerie()
        {
            cmbMateria.Items.Clear();
            cmbMateria.Text = "";
            listQuestoes.Items.Clear();
            domainUpDownQuantidadeDeQuestoes.Items.Clear();
            cbRecuperacao.Checked = false;

            List<Materia> materiaSegundaSerie = new List<Materia>();

            foreach (Materia materia in repositorioMateria.SelecionarTodos())
            {
                if (materia.Serie == "2ª")
                    materiaSegundaSerie.Add(materia);
            }

            foreach (Materia materia in materiaSegundaSerie)
            {
                if (materia.Disciplina.Nome == cmbDisciplina.Text)
                    cmbMateria.Items.Add(materia);
            }
            cmbMateria.DisplayMember = "NomeMateria";
        }
        #endregion

        #region Carrega questões na listQuestões de acordo com a matéria
        private void CarregarQuestoes()
        {
            listQuestoes.Items.Clear();

            string serie;

            if (radioButton1Serie.Checked == true)
                serie = "1ª";
            else
                serie = "2ª";

            List<ModuloQuestao.Questao> questaoPorSerie = new List<ModuloQuestao.Questao>();

            foreach (ModuloQuestao.Questao questao in repositorioQuestao.SelecionarTodos())
            {
                if (questao.Materia.Serie == serie)
                    questaoPorSerie.Add(questao);
            }

            foreach (ModuloQuestao.Questao questao in questaoPorSerie)
            {
                if (questao.Materia.NomeMateria == cmbMateria.Text)
                    listQuestoes.Items.Add(questao.Enunciado);
            }
        }
        #endregion

        #region Carrega questões na listQuestoes levando em consideração que é teste de recuperação, deverá ser aplicado questões de todas as matérias
        private void CarregarQuestoesRecuperacao()
        {
            listQuestoes.Items.Clear();

            string serie;

            if (radioButton1Serie.Checked == true)
                serie = "1ª";
            else
                serie = "2ª";

            List<ModuloQuestao.Questao> questaoPorSerie = new List<ModuloQuestao.Questao>();

            foreach (ModuloQuestao.Questao questao in repositorioQuestao.SelecionarTodos())
            {
                if (questao.Materia.Serie == serie)
                    questaoPorSerie.Add(questao);
            }

            foreach (ModuloQuestao.Questao questao in questaoPorSerie)
            {
                if (questao.Materia.Disciplina.Nome == cmbDisciplina.Text)
                    listQuestoes.Items.Add(questao);
            }

            listQuestoes.DisplayMember = "Enunciado";
        }
        #endregion

        private void cmbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1Serie.Checked == true)
                CarregarMateriasPrimeiraSerie();
            else
                CarregarMateriasSegundaSerie();
        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRecuperacao.Checked == false)
                CarregarQuestoes();
            else
                CarregarQuestoesRecuperacao();

            if (cmbMateria.Text != "")
                btnSortear.Enabled = true;
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            SortearQuestoes();
        }

        #region Realiza o sorteio das questões
        private void SortearQuestoes()
        {
            if (domainUpDownQuantidadeDeQuestoes.Text != "")
            {
                Random numeroAleatorio = new Random();
                List<ModuloQuestao.Questao> questoesListadas = new List<ModuloQuestao.Questao>();
                List<ModuloQuestao.Questao> questoesSorteadas = new List<ModuloQuestao.Questao>();
                int indexControlador;
                int numeroQuestoes = Convert.ToInt32(domainUpDownQuantidadeDeQuestoes.Text);

                if ((numeroQuestoes < 1) || (numeroQuestoes > listQuestoes.Items.Count))
                {
                    MessageBox.Show($"Por favor informe um número maior que 0 e menor que {listQuestoes.Items.Count + 1} para quantidade de questões a serem sorteadas!");
                    domainUpDownQuantidadeDeQuestoes.Items.Clear();
                    domainUpDownQuantidadeDeQuestoes.Focus();
                    return;
                }
                else
                {
                    foreach (ModuloQuestao.Questao questao in listQuestoes.Items)
                    {
                        questoesListadas.Add(questao);
                    }

                    for (int i = 0; i < numeroQuestoes; i++)
                    {
                        indexControlador = numeroAleatorio.Next(questoesListadas.Count);

                        questoesSorteadas.Add(questoesListadas[indexControlador]);

                        questoesListadas.RemoveAt(indexControlador);
                    }

                    listQuestoes.Items.Clear();

                    foreach (ModuloQuestao.Questao questao in questoesSorteadas)
                    {
                        listQuestoes.Items.Add(questao);
                    }
                }
            }
            else
            {
                MessageBox.Show($"Por favor informe o número de questões a serem sorteadas!");
                domainUpDownQuantidadeDeQuestoes.Focus();
            }
        }
        #endregion

        private void domainUpDownQuantidadeDeQuestoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            VerificarSeTituloDoTesteExiste();

            GeradorTeste.ModuloDisciplina.Disciplina disciplina = new GeradorTeste.ModuloDisciplina.Disciplina();
            Materia materia = new Materia();
            List<ModuloQuestao.Questao> questoes = new List<ModuloQuestao.Questao>();

            string titulo = txtTitulo.Text;

            disciplina = (GeradorTeste.ModuloDisciplina.Disciplina)cmbDisciplina.SelectedItem;

            materia = (Materia)cmbMateria.SelectedItem;

            int totalDeQuestoes = Convert.ToInt32(domainUpDownQuantidadeDeQuestoes.Text);

            bool recuperacao = cbRecuperacao.Checked;

            questoes = listQuestoes.SelectedItems.Cast<Questao>().ToList();

            teste = new Teste(titulo, totalDeQuestoes, recuperacao, disciplina, materia, questoes);

            List<string> erros = teste.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        #region Verifica a ocorrencia do título sugerido pelo usuário
        private void VerificarSeTituloDoTesteExiste()
        {
            if (txtTitulo.Text != "")
            {
                List<Teste> testes = repositorioTeste.SelecionarTodos();

                foreach (Teste teste in testes)
                {
                    if (txtTitulo.Text == teste.Titulo)
                    {
                        MessageBox.Show("O Título sugerido já existe, por favor informe outro Título!");
                        txtTitulo.Focus();
                        txtTitulo.SelectionStart = 0;
                        txtTitulo.SelectionLength = txtTitulo.Text.Length;

                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor Digite o Título do teste!");
                txtTitulo.Focus();
            }
        }
        #endregion

        #region Validação dos campos
        private void ValidarCampos()
        {
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("Por favor informe um Título para o teste!");
                txtTitulo.Focus();
                return;
            }
            else if (cmbDisciplina.Text == "")
            {
                MessageBox.Show("Por favor informe uma Disciplina!");
                cmbDisciplina.Focus();
                return;
            }
            else if (domainUpDownQuantidadeDeQuestoes.Text == "")
            {
                MessageBox.Show("Por favor informe a quantidade de questões do teste");
                domainUpDownQuantidadeDeQuestoes.Focus();
                return;
            }
            else if (cmbMateria.Text == "")
            {
                MessageBox.Show("Por favor informe uma Materia!");
                cmbMateria.Focus();
                return;
            }
            else if (listQuestoes.Items.Count <= 0)
            {
                MessageBox.Show("Por favor defina uma lista de questões para o teste!");
                btnSortear.Focus();
                return;
            }
            else
                btnGravar.DialogResult = DialogResult.OK;
        }
        #endregion

        private void cbRecuperacao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRecuperacao.Checked == true)
            {
                CarregarQuestoesRecuperacao();
                cmbMateria.Items.Clear();
                cmbMateria.SelectedIndex = -1;
                cmbMateria.Enabled = false;
            }
            else
            {
                listQuestoes.Items.Clear();
                cmbMateria.Enabled = true;

                if(radioButton1Serie.Checked == true)
                    CarregarMateriasPrimeiraSerie();
                else
                    CarregarMateriasSegundaSerie();
            }
        }

        private void radioButton2Serie_CheckedChanged(object sender, EventArgs e)
        {
            cmbDisciplina.Items.Clear();
            cmbDisciplina.SelectedIndex = -1;

            cmbMateria.Items.Clear();
            cmbMateria.SelectedIndex = -1;

            listQuestoes.Items.Clear();

            CarregarDisciplinas();
            CarregarMateriasSegundaSerie();
        }

        private void radioButton1Serie_CheckedChanged(object sender, EventArgs e)
        {
            cmbDisciplina.Items.Clear();
            cmbDisciplina.SelectedIndex = -1;

            cmbMateria.Items.Clear();
            cmbMateria.SelectedIndex = -1;

            listQuestoes.Items.Clear();

            CarregarDisciplinas();
            CarregarMateriasPrimeiraSerie();
        }
    }
}