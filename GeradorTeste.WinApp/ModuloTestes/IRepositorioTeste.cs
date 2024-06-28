using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorTeste.WinApp.ModuloQuestao;

namespace GeradorTeste.WinApp.ModuloTestes
{
    public interface IRepositorioTeste 
    {
        void Cadastrar(Teste novoTeste);

        void CadastrarVarios(List<Teste> teste);

        bool Editar(int id, Teste testeEditado);

        bool Excluir(int id);

        Teste SelecionarPorId(int idSelecionado);

        List<Teste> SelecionarTodos();

  
    }
}
