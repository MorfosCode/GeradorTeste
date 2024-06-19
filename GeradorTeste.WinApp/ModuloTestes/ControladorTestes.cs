using GeradorTeste.WinApp.Compartilhado;
using GeradorTeste.WinApp.ModuloTestes.ModuloPDF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GeradorTeste.WinApp.ModuloTestes
{
    public class ControladorTestes : ControladorBase, IControladorPDF
    {
       

        public override string TipoCadastro => "Teste";

        public override string ToolTipAdicionar => "Gerar PFD do Teste";

        public override string ToolTipEditar => "Gerar PFD do Teste";

        public override string ToolTipExcluir => "Gerar PFD do Teste";

        public string ToolTipGerarPDF => "Gerar PFD do Teste";

        public override void Adicionar()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }

        public void PDF()
        {
            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();
            Teste testeSelecionado = repositorioTeste.SelecionarPorId(idSelecionado);
            TelaPdfForm tela = new TelaPdfForm();
        }


    }
}
