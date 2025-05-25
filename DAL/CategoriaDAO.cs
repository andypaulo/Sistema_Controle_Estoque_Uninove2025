using Oracle.ManagedDataAccess.Client;
using Sistema_de_Estoque_de_Produtos___UNINOVE.Models;
using System.Data;

namespace Sistema_de_Estoque_de_Produtos___UNINOVE.DAL
{
    class CategoriaDAO
    {
        public static void InserirCategoria(Categoria categoria)
        {
            using (OracleConnection connection = OracleDbConnection.GetConnection())
            {
                string sql = "INSERT INTO categorias (nome, descricao) " +
                             "VALUES (:nome, :descricao) RETURNING id_categoria INTO :id";

                OracleCommand command = new OracleCommand(sql, connection);
                command.BindByName = true;

                command.Parameters.Add("nome", OracleDbType.Varchar2).Value = categoria.Nome;
                command.Parameters.Add("descricao", OracleDbType.Clob).Value = categoria.Descricao;

                command.Parameters.Add("id", OracleDbType.Int32).Direction = ParameterDirection.Output;

                OracleParameter idParam = new OracleParameter("id", OracleDbType.Int32);
                idParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(idParam);

                command.ExecuteNonQuery();
                categoria.IdCategoria = Convert.ToInt32(idParam.Value);
            }
        }
    }
}
