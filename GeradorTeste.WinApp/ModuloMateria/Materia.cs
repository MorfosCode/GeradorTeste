using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorTeste.ModuloDisciplina;
using GeradorTeste.WinApp.Compartilhado;

namespace GeradorTeste.WinApp.ModuloMateria
{
    public class Materia : EntidadeBase
    {
        public Disciplina Disciplina { get; set; }
        public string Nome { get; set; }
        public string Serie { get; set; }

        public Materia()
        {
            
        }

        public Materia(Disciplina disciplina, string nome, string serie)
        {
            this.Disciplina = disciplina;
            this.Nome = nome;
            this.Serie = serie;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
