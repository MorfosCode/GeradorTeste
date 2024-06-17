using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorTeste.ModuloDisciplina;

namespace GeradorTeste.WinApp.ModuloCadastrarQuestao
{
    public interface IRepositorioQuestao
    {
        void Cadastrar(Questao novaQuestao);

        void CadastrarVarios(List<Questao> questoes);

        bool Editar(int id, Questao questaoEditada);

        bool Excluir(int id);

        Questao SelecionarPorId(int idSelecionado);

        List<Questao> SelecionarTodos();
    }
}
