using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorTeste.ModuloDisciplina;
using GeradorTeste.WinApp.Compartilhado;
using GeradorTeste.WinApp.ModuloDisciplina;
using GeradorTeste.WinForms.ModuloDisciplina;

namespace GeradorTeste.WinApp.ModuloCadastrarQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        IRepositorioQuestao repositorioQuestao;
        private TabelaQuestaoControl tabelaQuestao;

        public ControladorQuestao(IRepositorioQuestao repositorioQuestao)
        {
            this.repositorioQuestao = repositorioQuestao;
        }

        #region Declarações
        public override string TipoCadastro { get { return "Questão"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar Questão"; } }

        public override string ToolTipEditar { get { return "Editar Questão";  } }

        public override string ToolTipExcluir { get { return "Excluir Questão"; } }
        #endregion

        #region Adiciona nova questão aos registro
        public override void Adicionar()
        {
            TelaCadastroQuestao telaQuestao = new TelaCadastroQuestao();
            DialogResult resultado = telaQuestao.ShowDialog();
            if (resultado != DialogResult.OK)
                return;

            Questao novaQuestao = telaQuestao.Questao;
            repositorioQuestao.Cadastrar(novaQuestao);

            CarregarQuestoes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaQuestao.Materia.NomeMateria + ", " + novaQuestao.Materia.Serie}\" foi criado com sucesso!");
        }
        #endregion

        #region Edita questão
        public override void Editar()
        {
            TelaCadastroQuestao telaQuestao = new TelaCadastroQuestao();

            int idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            Questao questaoSelecionada = repositorioQuestao.SelecionarPorId(idSelecionado);

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            telaQuestao.Questao = questaoSelecionada;

            DialogResult resultado = telaQuestao.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Questao questaoEditada = telaQuestao.Questao;

            repositorioQuestao.Editar(questaoSelecionada.Id, questaoEditada);

            CarregarQuestoes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{questaoEditada.Materia.NomeMateria + ", " + questaoEditada.Materia.Serie}\" foi editado com sucesso!");
        }
        #endregion

        #region Exclui questão de registro
        public override void Excluir()
        {
            int idSelecionado = tabelaQuestao.ObterRegistroSelecionado();

            Questao questaoSelecionada = repositorioQuestao.SelecionarPorId(idSelecionado);

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show
            (
              $"Você deseja realmente excluir o registro \"{questaoSelecionada.Materia.NomeMateria + ", " + questaoSelecionada.Materia.Serie}\"?",
              "Confirmar Exclusão",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioQuestao.Excluir(questaoSelecionada.Id);

            CarregarQuestoes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{questaoSelecionada.Materia.NomeMateria + ", " + questaoSelecionada.Materia.Serie}\" foi excluído com sucesso!");
        }
        #endregion

        #region Obtem lista de questoes
        public override UserControl ObterListagem()
        {
            if (tabelaQuestao == null)
                tabelaQuestao = new TabelaQuestaoControl();

            CarregarQuestoes();

            return tabelaQuestao;
        }
        #endregion

        #region Carrega questões
        private void CarregarQuestoes()
        {
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();
            tabelaQuestao.AtualizarRegistros(questoes);
        }
        #endregion
    }
}
