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

namespace GeradorTeste.WinApp.ModuloDisciplina
{
    public partial class TabelaDisciplinaControl : UserControl
    {
        public TabelaDisciplinaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(obterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();

        }

        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            grid.Rows.Clear();
            foreach (Disciplina disciplina in disciplinas)
                grid.Rows.Add
                (
                    disciplina.Id,
                    disciplina.Nome
                  

                );
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }
        private static DataGridViewColumn[] obterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn{ DataPropertyName = "Id", HeaderText = "ID" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Disciplina", HeaderText = "Disciplina" },
              
            };
        }
    }
}
