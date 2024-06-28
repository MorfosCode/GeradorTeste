using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorTeste.ModuloDisciplina;
using GeradorTeste.WinApp.Compartilhado;
using GeradorTeste.WinApp.ModuloMateria;
using GeradorTeste.WinApp.ModuloQuestao;

namespace GeradorTeste.WinApp.ModuloTestes
{
    public class Teste : EntidadeBase
    {
        public string Titulo { get; set; }
        public int QuantidadeQuestoes { get; set; }
        public bool Recuperacao { get; set; }
        public GeradorTeste.ModuloDisciplina.Disciplina Disciplina { get; set; }
        public Materia Materia { get; set; }
        public List<ModuloQuestao.Questao> Questoes { get; set; }

        #region Métodos construtores de classe
        public Teste() { }

        public Teste(string titulo, int quantidadeQuestoes, bool recuparacao, GeradorTeste.ModuloDisciplina.Disciplina disciplina, Materia materia, List<ModuloQuestao.Questao> questoes)
        {
            this.Titulo = titulo;
            this.QuantidadeQuestoes = quantidadeQuestoes;
            this.Recuperacao = recuparacao;
            this.Disciplina = disciplina;
            this.Materia = materia;
            this.Questoes = questoes;
        }
        #endregion

        #region Atualiza registro
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Teste testeAtualizado = (Teste)novoRegistro;

            Titulo = testeAtualizado.Titulo;
            QuantidadeQuestoes = testeAtualizado.QuantidadeQuestoes;
            Disciplina = testeAtualizado.Disciplina;
            Materia = testeAtualizado.Materia;
            Questoes = testeAtualizado.Questoes;
        }
        #endregion

        #region Valida registro
        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O campo \"TÍTULO\" é obrigatório!");

            if (string.IsNullOrEmpty(QuantidadeQuestoes.ToString().Trim()))
                erros.Add("O campo \"QUANTIDADE\" é obrigatório!");

            return erros;
        }
        #endregion

        public override string ToString()
        {
            return $"{Titulo}";
        }

    }
}
