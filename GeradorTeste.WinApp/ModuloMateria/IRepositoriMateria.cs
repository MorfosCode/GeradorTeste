﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorTeste.WinApp.ModuloMateria
{
    public interface IRepositoriMateria
    {

        void Cadastrar(Materia novaMateria);

        void CadastrarVarios(List<Materia> materias);

        bool Editar(int id, Materia materiaEditado);
        bool Excluir(int id);

        Materia SelecionarPorId(int idSelecionado);

        List<Materia> SelecionarTodos();
    }
}