using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorTeste.WinApp.ModuloTestes.ModuloPDF
{
    public interface IControladorPDF
    {
        string ToolTipGerarPDF { get; }

        void PDF();

    }
}
