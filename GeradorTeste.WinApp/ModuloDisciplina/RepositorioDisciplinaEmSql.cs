using GeradorTeste.ModuloDisciplina;
using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GeradorTeste.WinApp.ModuloDisciplina
{
    public class RepositorioDisciplinaEmSql : IRepositorioDisciplina
    {

        private string enderecoBanco;

        public RepositorioDisciplinaEmSql()
        {
            enderecoBanco = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=GeradorTestes;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=False";
        }

        public void Cadastrar(Disciplina novaDisciplina)
        {
            string sqlInserir =
                @"INSERT INTO [TBDISCIPLINA]
                        (
                            [NOME]

                        )
                        VALUES
                        (
                            @NOME
                        );
                        SELECT SCOPE_IDENTITY();";

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexaoComBanco);

            ConfigurarParametrosDisciplina(novaDisciplina, comandoInsercao);

            conexaoComBanco.Open();

            object id = comandoInsercao.ExecuteScalar();

            novaDisciplina.Id = Convert.ToInt32(id);

            conexaoComBanco.Close();



        }


        public bool Editar(int id, Disciplina disciplinaEditado)
        {
            string sqlEditar =
               @"UPDATE [TBDiSCIPLINA]	
		            SET
			            [NOME] = @NOME
			           
		            WHERE
			            [ID] = @ID";

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoEdicao = new SqlCommand(sqlEditar, conexaoComBanco);

            disciplinaEditado.Id = id;
            
            ConfigurarParametrosDisciplina(disciplinaEditado, comandoEdicao);

            conexaoComBanco.Open();

            int numeroRegistrosAfetados = comandoEdicao.ExecuteNonQuery();

            conexaoComBanco.Close();

            if (numeroRegistrosAfetados < 1)
                return false;

            return true;
        }

        public bool Excluir(int id)
        {
            string sqlExcluir =
               @"DELETE FROM [TBDISCIPLINA]
		            WHERE
			            [ID] = @ID";

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoExclusao = new SqlCommand(sqlExcluir, conexaoComBanco);

            comandoExclusao.Parameters.AddWithValue("ID", id);

            conexaoComBanco.Open();

            int numeroRegistrosExcluidos = comandoExclusao.ExecuteNonQuery();

            conexaoComBanco.Close();

            if (numeroRegistrosExcluidos < 1)
                return false;

            return true;
        }

        public Disciplina SelecionarPorId(int idSelecionado)
        {
            string sqlSelecionarPorId =
                  @"Select
                            [id],
                            [NOME]
                    FROM
                            [TBDISCIPLINA]

                    WHERE
                          [ID] = @ID";

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarPorId, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("ID", idSelecionado);


            conexaoComBanco.Open();

            SqlDataReader leitor = comandoSelecao.ExecuteReader();

            Disciplina disciplina = null;

            if (leitor.Read())
                disciplina = ConverterParaDisciplina(leitor);

            conexaoComBanco.Close();

            return disciplina;

        }

        private Disciplina ConverterParaDisciplina(SqlDataReader leitorDisciplina)
        {
           Disciplina disciplina =new Disciplina()
            {
                Id = Convert.ToInt32(leitorDisciplina["ID"]),
                Nome = Convert.ToString(leitorDisciplina["NOME"]),
            };

            return disciplina;
        }

        public List<Disciplina> SelecionarTodos()
        {
            string sqlSelecionarTodos =
              @"SELECT 
		            [ID], 
		            [NOME]
	            FROM
                     [TBDISCIPLINA]";

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarTodos, conexaoComBanco);

            conexaoComBanco.Open() ;    

            SqlDataReader leitorDisciplina = comandoSelecao.ExecuteReader();

            List <Disciplina> disciplinas = new List<Disciplina>();

            while(leitorDisciplina.Read())
            {
                Disciplina disciplina = ConverterParaDisciplina(leitorDisciplina);

                disciplinas.Add(disciplina);
            }

            conexaoComBanco.Close() ;

            return disciplinas;

        }
        private void ConfigurarParametrosDisciplina(Disciplina disciplina, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("ID", disciplina.Id);
            comando.Parameters.AddWithValue("NOME", disciplina.Nome);
        }

    }
}

