using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeradorTeste.WinApp.Compartilhado;
using GeradorTeste.WinApp.ModuloQuestao;

namespace GeradorTeste.WinApp.ModuloTestes
{
    public partial class TabelaTesteControl : UserControl
    {
        #region Construdtor de classe
        public TabelaTesteControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(obterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }
        #endregion

        #region Atualiza registro na tabela
        public void AtualizarRegistros(List<Teste> testes)
        {
            grid.Rows.Clear();

            foreach (Teste teste in testes)
            {
                string recuperacao;

                if (teste.Recuperacao == true)
                    recuperacao = "Sim";
                else
                    recuperacao = "Não";

                grid.Rows.Add
                    (
                        teste.Id,
                        teste.Titulo,
                        teste.Disciplina.Nome,
                        teste.Materia.Serie,
                        teste.Materia.NomeMateria,
                        teste.QuantidadeQuestoes,
                        recuperacao
                    );
            }
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
                new DataGridViewTextBoxColumn{ DataPropertyName = "Titulo", HeaderText = "TÍTULO" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Disciplina", HeaderText = "DISCIPLINA" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Serie", HeaderText = "SÉRIE" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Materia", HeaderText = "MATÉRIA" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "NumeroQuestoes", HeaderText = "Nº QUESTÕES" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Recuperacao", HeaderText = "RECUPERAÇÃO" }
            };

        }
        #endregion
    }
}
