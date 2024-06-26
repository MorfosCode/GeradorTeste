using GeradorTeste.ModuloDisciplina;

namespace GeradorTeste.WinApp.ModuloDisciplina
{
    public interface IRepositorioDisciplina
    {
        void Cadastrar(Disciplina novaDisciplina);


        bool Editar(int id, Disciplina disciplinaEditado);
        bool Excluir(int id);

        Disciplina SelecionarPorId(int idSelecionado);

        List<Disciplina> SelecionarTodos();
    }
}