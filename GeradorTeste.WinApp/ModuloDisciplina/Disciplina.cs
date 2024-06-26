

using GeradorTeste.WinApp.Compartilhado;
using GeradorTeste.WinApp.ModuloMateria;

namespace GeradorTeste.ModuloDisciplina
{

    public class Disciplina : EntidadeBase
    {
       

        public string Nome { get; set; }
        public List<Materia> Materias { get; set; }


        public Disciplina()
        {
            Materias = new List<Materia>(); 
        }

        public Disciplina(string nome)
        {

            Nome = nome;

        }
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Disciplina atualizar = (Disciplina)novoRegistro;                

            Nome = atualizar.Nome;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
            erros.Add("O campo \"DISCIPLINA\" é obrigatório");

            if (Nome.Trim().Length < 3)
                erros.Add("O nome da disciplina deve conter ao menos 3 caracteres!");

            return erros;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }


        public bool AdicionaMateria(Materia materia)
        { 
            if (Materias.Contains(materia))
                return false;
            
            Materias.Add(materia);
           
            return true;

        
        }


        public bool RemoveMateria(Materia materia)
        {
            if (!Materias.Contains(materia)) 
                return false;

            Materias.Remove(materia);

            return true;


        }
    }
}