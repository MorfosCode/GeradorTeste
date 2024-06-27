using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorTeste.WinApp.Compartilhado;
using GeradorTeste.WinApp.ModuloCadastrarQuestao;
using GeradorTeste.WinApp.ModuloTestes.ModuloPDF;

namespace GeradorTeste.WinApp.ModuloTestes
{
    public class ControladorTeste : ControladorBase, IControladorPDF, IControladorDuplicavel
    {
        IRepositorioTeste repositorioTeste;
        private TabelaTesteControl tabelaTeste;

        public ControladorTeste(IRepositorioTeste repositorioTeste)
        {
            this.repositorioTeste = repositorioTeste;
        }

        #region Declarações

        public override string TipoCadastro { get { return "Teste"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar Teste"; } }

        public override string ToolTipEditar { get { return "Editar Teste"; } }

        public override string ToolTipExcluir { get { return "Excluir Teste"; } }

        public string ToolTipGerarPDF => "Gerar PDF de Teste";

        public string ToolTipDuplicar => "Duplicar um Teste existente";

        #endregion

        #region Adiciona novo registro teste
        public override void Adicionar()
        {
            TelaCadastroTesteForm telaCadastroTeste = new TelaCadastroTesteForm();
            DialogResult resultado = telaCadastroTeste.ShowDialog();

            if(resultado != DialogResult.OK)
                return;

            Teste novoTeste = telaCadastroTeste.Teste;
            repositorioTeste.Cadastrar(novoTeste);

            CarregarTestes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoTeste.Titulo}\" foi criado com sucesso!");
        }
        #endregion

        #region Edita um registro de teste
        public override void Editar()
        {
            TelaCadastroTesteForm telaTeste = new TelaCadastroTesteForm();

            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado = repositorioTeste.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            telaTeste.Teste = testeSelecionado;

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste testeEditado = telaTeste.Teste;

            repositorioTeste.Editar(testeSelecionado.Id, testeEditado);

            CarregarTestes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{testeEditado.Titulo}\" foi editado com sucesso!");
        }
        #endregion

        #region Exclui teste
        public override void Excluir()
        {
            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado = repositorioTeste.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show
            (
              $"Você deseja realmente excluir o registro \"{testeSelecionado.Titulo}\"?",
              "Confirmar Exclusão",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioTeste.Excluir(testeSelecionado.Id);

            CarregarTestes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{testeSelecionado.Titulo}\" foi excluído com sucesso!");
        }
        #endregion

        public void PDF()
        {
            TelaPdfForm telaTeste = new TelaPdfForm();
          


            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado = repositorioTeste.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            telaTeste.Teste = testeSelecionado;

            
            CarregarTestes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O PDF do registro \"{testeSelecionado}\" foi gerado com sucesso!");
            
        }


        public void Duplicar()
        {
            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

            Teste testeSelecionado = repositorioTeste.SelecionarPorId(idSelecionado);

            if (testeSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            TelaCadastroTesteForm telaCadastroTeste = new TelaCadastroTesteForm();

            telaCadastroTeste.Teste = testeSelecionado;
                
           
            DialogResult resultado = telaCadastroTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste testeDuplicado = telaCadastroTeste.Teste;
            repositorioTeste.Cadastrar(testeDuplicado);

            CarregarTestes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{testeDuplicado.Titulo}\" foi criado em uma duplicação com sucesso!");
        }



        #region Obtem listagem de testes nos registro
        public override UserControl ObterListagem()
        {
            if (tabelaTeste == null)
                tabelaTeste = new TabelaTesteControl();

            CarregarTestes();

            return tabelaTeste;
        }
        #endregion




        #region Carrega testes
        private void CarregarTestes()
        {
            List<Teste> testes = repositorioTeste.SelecionarTodos();
            tabelaTeste.AtualizarRegistros(testes);
        }

       
        #endregion



    }
}
