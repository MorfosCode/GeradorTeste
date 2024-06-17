
using GeradorTeste.WinApp.Compartilhado;
using GeradorTeste.WinApp.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorTeste.WinApp.ModuloMateria
{
   
    public class ControladorMateria : ControladorBase
    {

        private IRepositorioMateria repositorioMateria;
        private IRepositorioDisciplina repositorioDisciplina;

        private TabelaMateriaControl tabelaMateria;

        public ControladorMateria(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override string TipoCadastro { get { return "Material"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova Materia"; } }

        public override string ToolTipEditar { get { return "Editar uma Materia"; } }

        public override string ToolTipExcluir { get { return "Excluir uma Materia"; } }


        public override void Adicionar()
        {
            TelaCadastroMateriaForm telaCadastro = new TelaCadastroMateriaForm(repositorioDisciplina.SelecionarTodos());
            DialogResult resultado = telaCadastro.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Materia novaMateria = telaCadastro.Materia;
            repositorioMateria.Cadastrar(novaMateria);

            CarregarMateria();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaMateria.NomeMateria}\" foi criado com sucesso!");
        }

       

        public override void Editar()
        {

            TelaCadastroMateriaForm telaCadastro = new TelaCadastroMateriaForm(repositorioDisciplina.SelecionarTodos());

            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            Materia materiaSelecionado = repositorioMateria.SelecionarPorId(idSelecionado);

            if (materiaSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            telaCadastro.Materia = materiaSelecionado;

            DialogResult resultado = telaCadastro.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Materia materiaEditada = telaCadastro.Materia;
            repositorioMateria.Editar(materiaSelecionado.Id, materiaEditada);

            CarregarMateria();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{materiaEditada.NomeMateria}\" foi criado com sucesso!");

        }

        public override void Excluir()
        {
            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            Materia materiaSelecionado = repositorioMateria.SelecionarPorId(idSelecionado);

            if (materiaSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show(
             $"Você deseja realmente excluir o registro \"{materiaSelecionado.NomeMateria}\"?",
             "Confirmar Exclusão",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning
            );


            if (resposta != DialogResult.Yes)
                return;

            repositorioMateria.Excluir(materiaSelecionado.Id);

            CarregarMateria();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{materiaSelecionado.NomeMateria}\" foi excluído com sucesso!");

        }

        public override UserControl ObterListagem()
        {
            if (tabelaMateria == null)
                tabelaMateria = new TabelaMateriaControl();

            CarregarMateria();


            return tabelaMateria;
        }
        private void CarregarMateria()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            tabelaMateria.AtualizarRegistros(materias);
        }


    }
}
