using GeradorTeste.ModuloDisciplina;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorTeste.WinApp.ModuloMateria
{
    public class RepositorioMateriaEmSql : IRepositorioMateria
    {

        private string enderecoBanco;

        public RepositorioMateriaEmSql()
        {
            enderecoBanco = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=GeradorTestes;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=False";
        }

        private const string sqlInserir =
             @"INSERT INTO [TBMATERIA]
                        (
                            [NOMEMATERIA],
                            [SERIE], 
                            [DISCIPLINA_ID]

                        )
                        VALUES
                        (
                            @NOMEMATERIA,
                            @SERIE,
                            @DISCIPLINA_ID
                           
                        );
                        SELECT SCOPE_IDENTITY();";
        
        private const string sqlEditar =
             @"UPDATE [TBMATERIA]
                         SET
                              [NOMEMATERIA] =@NOMEMATERIA,
                              [SERIE] = @SERIE,
                              [DISCIPLINA_ID] = @DISCIPLINA_ID
                          WHERE
                               [ID] = @ID

                      ";

        private const string sqlExcluir =
             @"DELETE FROM [TBDISCIPLINA]
		            WHERE
			            [ID] = @ID";

        private const string sqlSelecionarTodos =
             @"SELECT 
                             MT.[ID],
                             MT.[NOMEMATERIA],
                             MT.[SERIE], 
                             MT.[DISCIPLINA_ID],
                             DP.[NOME]
                         FROM
                             [TBMATERIA] AS MT LEFT JOIN
                             [TBDISCIPLINA] AS DP
                           ON
                             DP.ID = MT.DISCIPLINA_ID;
                      ";

        private const string sqlSelecionarPorId =
             @"SELECT 
                  MT.[ID],
                  MT.[NOMEMATERIA],
                  MT.[SERIE], 
                  MT.[DISCIPLINA_ID],
                  DP.[NOME]
              FROM
                  [TBMATERIA] AS MT LEFT JOIN
                  [TBDISCIPLINA] AS DP
                ON
                  DP.ID = MT.DISCIPLINA_ID
             WHERE
                  MT.[ID] = @ID;";


        public void Cadastrar(Materia novaMateria)
        {

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexaoComBanco);

            ConfiguarParametrosMateria(novaMateria, comandoInsercao);

            conexaoComBanco.Open();

            object id = comandoInsercao.ExecuteScalar();
            novaMateria.Id = Convert.ToInt32(id);

            conexaoComBanco.Close();
        }

        public bool Editar(int id, Materia materiaEditada)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoEdicao = new SqlCommand(sqlEditar, conexaoComBanco);

            materiaEditada.Id = id;

            ConfiguarParametrosMateria(materiaEditada, comandoEdicao);

            conexaoComBanco.Open();

            int numeroRegistrosAfetados = comandoEdicao.ExecuteNonQuery();

            conexaoComBanco.Close();

            if (numeroRegistrosAfetados < 1)
                return false;

            return true;
        }

        public bool Excluir(int id)
        {

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

        public Materia SelecionarPorId(int idSelecionado)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarPorId, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("ID", idSelecionado);


            conexaoComBanco.Open();

            SqlDataReader leitorMateria = comandoSelecao.ExecuteReader();

            Materia materia = null;

            if (leitorMateria.Read())
                materia = ConverterParaMateria(leitorMateria);

            conexaoComBanco.Close();

            return materia;

        }

        public List<Materia> SelecionarTodos()
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarTodos, conexaoComBanco);

            conexaoComBanco.Open();
            SqlDataReader leitorMateria = comandoSelecao.ExecuteReader();

            List<Materia> materias = new List<Materia>();


            while (leitorMateria.Read())
            {

                Materia materia = ConverterParaMateria(leitorMateria);

                materias.Add(materia);
            }


            conexaoComBanco.Close();

            return materias;
        }

        private Materia ConverterParaMateria(SqlDataReader leitorMateria)
        {
            Materia materia = new Materia()
            {
                Id = Convert.ToInt32(leitorMateria["ID"]),
                NomeMateria = Convert.ToString(leitorMateria["NOMEMATERIA"]),
                Serie = Convert.ToString(leitorMateria["SERIE"]),

            };

            if (leitorMateria["DISCIPLINA_ID"] != DBNull.Value)
                materia.Disciplina = ConverterParaDisciplina(leitorMateria);


            return materia;
        }

        private Disciplina ConverterParaDisciplina(SqlDataReader leitorDisciplina)
        {
            Disciplina disciplina = new Disciplina()
            {
                Id = Convert.ToInt32(leitorDisciplina["DISCIPLINA_ID"]),
                Nome = Convert.ToString(leitorDisciplina["NOME"]),
            };

            return disciplina;
        }

        private static void ConfiguarParametrosMateria(Materia novaMateria, SqlCommand comandoInsercao)
        {
            comandoInsercao.Parameters.AddWithValue("Id", novaMateria.Id);
            comandoInsercao.Parameters.AddWithValue("NOMEMATERIA", novaMateria.NomeMateria);
            comandoInsercao.Parameters.AddWithValue("SERIE", novaMateria.Serie);

            object valorDaDisciplina = novaMateria.Disciplina == null ? DBNull.Value : novaMateria.Disciplina.Id;

            comandoInsercao.Parameters.AddWithValue("DISCIPLINA_ID", novaMateria.Disciplina.Id);
        }

    }
}
