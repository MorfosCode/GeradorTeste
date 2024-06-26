﻿

using GeradorTeste.WinApp.Compartilhado;

namespace GeradorTeste.ModuloDisciplina
{

    public class Disciplina : EntidadeBase
    {
       
        public Disciplina()
        {
        }

        public Disciplina(string nome) 
        { 
          
            Nome = nome;

        }

        public string Nome { get; set; }


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

            else if (Nome.Trim().Length < 3)
                erros.Add("O nome da disciplina deve conter ao menos 3 caracteres!");

            return erros;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}