using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorTeste.WinApp.ModuloMateria
{
    public interface IRepositorioMateria
    {

        void Cadastrar(Materia novaMateria);

        void CadastrarVarios(List<Materia> materias);

        bool Editar(int id, Materia materiaEditada);
        bool Excluir(int id);

        Materia SelecionarPorId(int idSelecionado);

        List<Materia> SelecionarTodos();
    }
}
