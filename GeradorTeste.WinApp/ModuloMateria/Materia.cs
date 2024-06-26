using GeradorTeste.ModuloDisciplina;
using GeradorTeste.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorTeste.WinApp.ModuloMateria
{
    public class Materia : EntidadeBase
    {
        public Disciplina Disciplina { get; set; }
        public string NomeMateria { get; set; }


        public string Serie { get; set; }

        public Materia()
        {

        }

        public Materia(Disciplina disciplina, string nome, string serie)
        {
            this.Disciplina = disciplina;
            this.NomeMateria = nome;
            this.Serie = serie;
        }

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
                erros.Add("O campo \"NomeMateria\" é obrigatório");

            if (NomeMateria.Length < 2)
                erros.Add($"O nome da matéria deve ter mais de 2 letras!");

            if (string.IsNullOrEmpty(Serie.Trim()))
                erros.Add("O checkbox \"Série\" é obrigatório");

            return erros;
        }

        public override string ToString()
        {
            return $"{{NomeMateria}} {{Serie}}, {{Disciplina}}";
        }

        public bool AtribuirDiciplina()
        {
            bool conseguiuAdicionar = Disciplina.AdicionaMateria(this);

            return conseguiuAdicionar;
        }


        public bool RemoverDiciplina()
        {
            bool conseguiuRemover = Disciplina.RemoveMateria(this);

            if (!conseguiuRemover)
                return false;

            Disciplina = null;
            return true;
        }
    }
}
