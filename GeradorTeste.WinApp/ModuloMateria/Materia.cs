using GeradorTeste.ModuloDisciplina;
using GeradorTeste.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorTeste.WinApp.ModuloMateria
{
    public  class Materia : EntidadeBase
    {
        public Materia(string nome, List<Disciplina> disciplina, string serie)
        {
            NomeMateria = nome;
            Disciplina = disciplina;
            Serie = serie;
        }

        public string NomeMateria { get; set; }

        public List <Disciplina> Disciplina { get; set; }

        public string Serie { get; set; }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Materia atualizar = (Materia)novoRegistro;

            NomeMateria = atualizar.NomeMateria;
            Disciplina = atualizar.Disciplina;
            Serie = atualizar.Serie;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(NomeMateria.Trim()))
                erros.Add("O campo \"DISCIPLINA\" é obrigatório");

            return erros;
        }
    }
}
