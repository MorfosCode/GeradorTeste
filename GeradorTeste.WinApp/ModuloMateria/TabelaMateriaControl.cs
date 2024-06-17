using GeradorTeste.ModuloDisciplina;
using GeradorTeste.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorTeste.WinApp.ModuloMateria
{
    public partial class TabelaMateriaControl : UserControl
    {
        public TabelaMateriaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(obterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Materia> materias)
        {
            grid.Rows.Clear();
            foreach (Materia materia in materias)
                grid.Rows.Add
                (
                    materia.Id,
                    materia.NomeMateria,
                    materia.Disciplina,
                    materia.Serie

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
                 new DataGridViewTextBoxColumn{ DataPropertyName = "materia", HeaderText = "Materia" },
                new DataGridViewTextBoxColumn{ DataPropertyName = "Disciplina", HeaderText = "Disciplina" }, 
                new DataGridViewTextBoxColumn{ DataPropertyName = "serie", HeaderText = "Serie" },

            };
        }
    }
}
