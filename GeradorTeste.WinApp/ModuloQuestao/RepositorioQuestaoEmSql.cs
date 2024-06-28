

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorTeste.WinApp.ModuloQuestao
{
    public class RepositorioQuestaoEmSql : IRepositorioQuestao
    {
        public void Cadastrar(Questao novaQuestao)
        {
            throw new NotImplementedException();
        }

        public bool Editar(int id, Questao questaoEditada)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Questao SelecionarPorId(int idSelecionado)
        {
            throw new NotImplementedException();
        }

        public List<Questao> SelecionarTodos()
        {
            throw new NotImplementedException();
        }

        private Questao ConverterParaQuestao(SqlDataReader leitorQuestao)
        {
            Questao questao = new Questao()
            {
                Id = Convert.ToInt32(leitorQuestao["ID"]),
                Enunciado = Convert.ToString(leitorQuestao["Enunciado"]),
            };

            return questao;
        }

        private static void ConfiguarParametrosMateria(Questao novaQuestao, SqlCommand comandoInsercao)
        {
            comandoInsercao.Parameters.AddWithValue("Id", novaQuestao.Id);

        }

    }
}
