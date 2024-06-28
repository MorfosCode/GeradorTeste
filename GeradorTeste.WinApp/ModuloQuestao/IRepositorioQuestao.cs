using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorTeste.WinApp.ModuloQuestao
{
    public interface IRepositorioQuestao
    {
        void Cadastrar(Questao novaQuestao);


        bool Editar(int id, Questao questaoEditada);

        bool Excluir(int id);

        Questao SelecionarPorId(int idSelecionado);

        List<Questao> SelecionarTodos();
    }
}
