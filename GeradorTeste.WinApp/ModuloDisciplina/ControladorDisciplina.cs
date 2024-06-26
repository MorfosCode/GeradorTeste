using GeradorTeste.ModuloDisciplina;
using GeradorTeste.WinApp;
using GeradorTeste.WinApp.Compartilhado;
using GeradorTeste.WinApp.ModuloDisciplina;
using GeradorTeste.WinForms.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorTeste.WinApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private IRepositorioDisciplina repositorioDisciplina;
        private TabelaDisciplinaControl tabelaDisciplina;

        public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override string TipoCadastro { get { return "Disciplina"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova Disciplina"; } }

        public override string ToolTipEditar { get { return "Editar um  Disciplina"; } }

        public override string ToolTipExcluir { get { return "Excluir um  Disciplina"; } }

        public override void Adicionar()
        {
            List<Disciplina> disciplinaCadastradas = repositorioDisciplina.SelecionarTodos();

            TelaCadastroQuestao telaCadastro = new TelaCadastroQuestao(disciplinaCadastradas);
            DialogResult resultado = telaCadastro.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

           Disciplina novaDisciplina = telaCadastro.Disciplina;
            repositorioDisciplina.Cadastrar(novaDisciplina);

            CarregarDisciplina();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaDisciplina.Nome}\" foi criado com sucesso!");
        }


        public override void Editar()
        {
            List<Disciplina> disciplinaCadastradas = repositorioDisciplina.SelecionarTodos();
            TelaCadastroQuestao telaCadastro = new TelaCadastroQuestao(disciplinaCadastradas);

            int idSelecionado = tabelaDisciplina.ObterRegistroSelecionado();

            Disciplina disciplinaSelecionado = repositorioDisciplina.SelecionarPorId(idSelecionado);

            if (disciplinaSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            telaCadastro.Disciplina = disciplinaSelecionado;

            DialogResult resultado = telaCadastro.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Disciplina diciplinaEditado = telaCadastro.Disciplina;

            repositorioDisciplina.Editar(disciplinaSelecionado.Id, diciplinaEditado);

            CarregarDisciplina();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{diciplinaEditado.Nome}\" foi editado com sucesso!");
        }


      

        public override void Excluir()
        {
            int idSelecionado = tabelaDisciplina.ObterRegistroSelecionado();

            Disciplina disciplinaSelecionado = repositorioDisciplina.SelecionarPorId(idSelecionado);

            if (disciplinaSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult resposta = MessageBox.Show(
              $"Você deseja realmente excluir o registro \"{disciplinaSelecionado.Nome}\"?",
              "Confirmar Exclusão",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning
             );

            if (resposta != DialogResult.Yes)
                return;

            repositorioDisciplina.Excluir(disciplinaSelecionado.Id);

            CarregarDisciplina();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{disciplinaSelecionado.Nome}\" foi excluído com sucesso!");

        }



        public override UserControl ObterListagem()
        {
            if (tabelaDisciplina == null)
                tabelaDisciplina = new TabelaDisciplinaControl();

            CarregarDisciplina();

            return tabelaDisciplina;
        }


        private void CarregarDisciplina()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
           
            tabelaDisciplina.AtualizarRegistros(disciplinas);
        }
       

    }
}
