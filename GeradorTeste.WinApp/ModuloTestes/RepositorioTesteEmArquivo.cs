using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorTeste.WinApp.Compartilhado;
using GeradorTeste.WinApp.ModuloQuestao;

namespace GeradorTeste.WinApp.ModuloTestes
{
    public class RepositorioTesteEmArquivo : RepositorioBaseEmArquivo<Teste>, IRepositorioTeste
    {
        public RepositorioTesteEmArquivo() : base("teste.json")
        {

        }

       
    }
}
