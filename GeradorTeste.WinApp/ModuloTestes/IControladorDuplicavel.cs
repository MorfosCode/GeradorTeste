using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorTeste.WinApp.ModuloTestes
{
    public interface IControladorDuplicavel
    {
        string ToolTipDuplicar {  get; }

        void Duplicar();
    }
}
