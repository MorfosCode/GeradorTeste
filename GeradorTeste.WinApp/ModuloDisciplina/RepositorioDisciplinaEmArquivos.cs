
using GeradorTeste.WinApp.Compartilhado;
using GeradorTeste.WinApp.ModuloDisciplina;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorTeste.ModuloDisciplina
{
    public class RepositorioDisciplinaEmArquivos : RepositorioBaseEmArquivo <Disciplina>, IRepositorioDisciplina
    {
        public RepositorioDisciplinaEmArquivos() : base("disciplina.json")
        {
              
         }

    }
}
