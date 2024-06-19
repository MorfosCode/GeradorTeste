using GeradorTeste.WinApp.Compartilhado;
using GeradorTeste.ModuloDisciplina;
using GeradorTeste.WinApp.ModuloDisciplina;
using GeradorTeste.WinApp.ModuloMateria;
using GeradorTeste.WinApp.ModuloCadastrarQuestao;
using GeradorTeste.WinApp.ModuloTestes;

namespace GeradorTeste.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;

        IRepositorioDisciplina repositorioDisciplina;
        IRepositorioMateria repositorioMateria;
        IRepositorioQuestao repositorioQuestao;
        IRepositorioTeste repositorioTeste;

        public static TelaPrincipalForm Instancia { get; private set; }
        public TelaPrincipalForm()
        {
            InitializeComponent();

            lblTipoCadastro.Text = string.Empty;
            Instancia = this;

            repositorioDisciplina = new RepositorioDisciplinaEmArquivos();
            repositorioMateria = new RepositorioMateriaEmArquivo();
            repositorioQuestao = new RepositorioQuestaoEmArquivo();
            repositorioTeste = new RepositorioTesteEmArquivo();
        }

        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemTestes = controladorSelecionado.ObterListagem();
            listagemTestes.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemTestes);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;


            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

        }



            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarTelaPrincipal(controlador);
        }

        private void questaoMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorQuestao(repositorioQuestao);

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            controlador.Excluir();
        }
        private void disciplinaMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDisciplina(repositorioDisciplina);

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarTelaPrincipal(controlador);
        }
        private void materiaMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorMateria(repositorioMateria, repositorioDisciplina);

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarTelaPrincipal(controlador);

        }

        private void questaoMenuItem_Click_1(object sender, EventArgs e)
        {
            controlador = new ControladorQuestao(repositorioQuestao);

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarTelaPrincipal(controlador);
        }

        private void testeMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTeste(repositorioTeste);

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarTelaPrincipal(controlador);
        }
    }
}
