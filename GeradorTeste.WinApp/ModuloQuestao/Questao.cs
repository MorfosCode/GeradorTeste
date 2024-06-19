using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorTeste.WinApp.Compartilhado;
using GeradorTeste.WinApp.ModuloMateria;

namespace GeradorTeste.WinApp.ModuloCadastrarQuestao
{
    public class Questao : EntidadeBase
    {
        public Materia Materia { get; set; }
        public string Enunciado { get; set; }
        public List<string> Alternativas { get; set; }
        public string AlternativaCorreta { get; set; }

        #region Construtores de classe
        public Questao()
        {

        }

        public Questao (Materia materia, string enunciado,  List<string> alternativas, string AlternativaCorreta)
        {
            this.Materia = materia;
            this.Enunciado = enunciado;
            this.Alternativas = alternativas;
            this.AlternativaCorreta = AlternativaCorreta;
        }
        #endregion

        #region Atualiza registro de questão
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Questao questaoAtualizada = (Questao)novoRegistro;

            Materia = questaoAtualizada.Materia;
            Enunciado = questaoAtualizada.Enunciado;
            Alternativas = questaoAtualizada.Alternativas;
            AlternativaCorreta = questaoAtualizada.AlternativaCorreta;
        }
        #endregion

        #region Valida novo registro de questão
        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Materia.NomeMateria.Trim()))
                erros.Add("O campo \"MATÉRIA\" é obrigatório!");

            if(string.IsNullOrEmpty(Enunciado.Trim()))
                erros.Add("O campo \"ENUNCIADO\" é obrigatório!");

            if(Alternativas.Count < 2)
                erros.Add("Precisa ter ao menos duas altenativas na lista!");
            
            if (string.IsNullOrEmpty(AlternativaCorreta.Trim()))
                erros.Add("Precisa ter uma \"ALTERNATIVA CORRETA\"!");

            return erros;
        }
        #endregion
    }
}
