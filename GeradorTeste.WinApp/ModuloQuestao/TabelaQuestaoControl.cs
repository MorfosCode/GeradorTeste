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
using GeradorTeste.WinApp.Compartilhado;
using GeradorTeste.WinApp.ModuloCadastrarQuestao;
using GeradorTeste.WinApp.ModuloTestes;
namespace GeradorTeste.WinApp.ModuloCadastrarQuestao
{
    public partial class TabelaQuestaoControl : UserControl
    {
        #region Construtor de classe
        public TabelaQuestaoControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(obterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }
        #endregion

        #region Atualiza registro na tabela
        public void AtualizarRegistros(List<Questao> questoes)
        {
            grid.Rows.Clear();

            foreach (Questao questao in questoes)
                grid.Rows.Add
                    (
                        questao.Id,
                        questao.Materia.NomeMateria,
                        questao.Materia.Serie,
                        questao.Enunciado,
                        questao.AlternativaCorreta.ToString()
                    );
        }
        #endregion

        #region Obtem regitro selecionado através do id
        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }
        #endregion

        #region Configuração das colunas
        private static DataGridViewColumn[] obterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn{ DataPropertyName = "Id", HeaderText = "ID" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Materia", HeaderText = "MATÉRIA" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Serie", HeaderText = "SÉRIE" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Enunciado", HeaderText = "ENUNCIADO" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Disciplina", HeaderText = "QUESTÃO CORRETA" }
            };

        }
        #endregion
    }
}