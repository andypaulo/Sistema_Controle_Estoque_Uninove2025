using Oracle.ManagedDataAccess.Client;
using Sistema_de_Estoque_de_Produtos___UNINOVE.Models;
using System.Data;

public class ProdutoDAO
{
    // CREATE
    public static void InserirProduto(Produto produto)
    {
        using (OracleConnection connection = OracleDbConnection.GetConnection())
        {
            string sql = "INSERT INTO produtos (nome, descricao, preco, quantidade_estoque, id_categoria) " +
                         "VALUES (:nome, :descricao, :preco, :quantidade, :idCategoria) RETURNING id_produto INTO :id";

            OracleCommand command = new OracleCommand(sql, connection);
            command.BindByName = true;

            command.Parameters.Add("nome", OracleDbType.Varchar2).Value = produto.Nome;
            command.Parameters.Add("descricao", OracleDbType.Clob).Value = produto.Descricao;
            command.Parameters.Add("preco", OracleDbType.Decimal).Value = produto.Preco;
            command.Parameters.Add("quantidade", OracleDbType.Int32).Value = produto.QuantidadeEstoque;
            command.Parameters.Add("idCategoria", OracleDbType.Int32).Value = produto.IdCategoria;

            command.Parameters.Add("id", OracleDbType.Int32).Direction = ParameterDirection.Output;

            OracleParameter idParam = new OracleParameter("id", OracleDbType.Int32);
            idParam.Direction = ParameterDirection.Output;
            command.Parameters.Add(idParam);

            command.ExecuteNonQuery();
            produto.IdProduto = Convert.ToInt32(idParam.Value);
        }
    }

    // READ
    public static DataTable ListarProdutos(string nome = "", string desc = "", string preco = "", string quantidade = "", int? idCategoria = null)
    {
        using (OracleConnection connection = OracleDbConnection.GetConnection())
        {
            string sql = @"
            SELECT p.id_produto, p.nome, p.descricao, p.preco, p.quantidade_estoque,
                   p.id_categoria, c.nome as categoria
            FROM produtos p
            LEFT JOIN categorias c ON p.id_categoria = c.id_categoria
            WHERE 1=1";

            var command = new OracleCommand();
            command.Connection = connection;

            if (!string.IsNullOrWhiteSpace(nome))
            {
                sql += " AND LOWER(p.nome) LIKE :nome";
                command.Parameters.Add(new OracleParameter("nome", $"%{nome.ToLower()}%"));
            }

            if (!string.IsNullOrWhiteSpace(desc))
            {
                sql += " AND LOWER(p.descricao) LIKE :desc";
                command.Parameters.Add(new OracleParameter("desc", $"%{desc.ToLower()}%"));
            }

            if (!string.IsNullOrWhiteSpace(preco) && decimal.TryParse(preco, out decimal precoVal))
            {
                sql += " AND p.preco = :preco";
                command.Parameters.Add(new OracleParameter("preco", precoVal));
            }

            if (!string.IsNullOrWhiteSpace(quantidade) && int.TryParse(quantidade, out int qtdVal))
            {
                sql += " AND p.quantidade_estoque = :quantidade";
                command.Parameters.Add(new OracleParameter("quantidade", qtdVal));
            }

            if (idCategoria != null)
            {
                sql += " AND p.id_categoria = :idCategoria";
                command.Parameters.Add(new OracleParameter("idCategoria", idCategoria));
            }

            command.CommandText = sql;

            var adapter = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
    // READ BY ID
    public static Produto BuscarPorId(int id)
    {
        Produto produto = null;

        using (OracleConnection connection = OracleDbConnection.GetConnection())
        {
            string sql = "SELECT * FROM produtos WHERE id_produto = :id";

            OracleCommand command = new OracleCommand(sql, connection);
            command.Parameters.Add("id", OracleDbType.Int32).Value = id;

            OracleDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                produto = new Produto
                {
                    IdProduto = Convert.ToInt32(reader["id_produto"]),
                    Nome = reader["nome"].ToString(),
                    Descricao = reader["descricao"].ToString(),
                    Preco = Convert.ToDecimal(reader["preco"]), 
                    QuantidadeEstoque = Convert.ToInt32(reader["quantidade_estoque"]),
                    IdCategoria = Convert.ToInt32(reader["id_categoria"])
                };
            }
        }

        return produto;
    }


    // UPDATE
    public static void AtualizarProduto(Produto produto)
    {
        using (OracleConnection connection = OracleDbConnection.GetConnection())
        {
            string sql = "UPDATE produtos SET nome = :nome, descricao = :descricao, preco = :preco, " +
                         "quantidade_estoque = :quantidade, id_categoria = :idCategoria " +
                         "WHERE id_produto = :id";

            OracleCommand command = new OracleCommand(sql, connection);
            command.Parameters.Add("nome", OracleDbType.Varchar2).Value = produto.Nome;
            command.Parameters.Add("descricao", OracleDbType.Clob).Value = produto.Descricao;
            command.Parameters.Add("preco", OracleDbType.Decimal).Value = produto.Preco;
            command.Parameters.Add("quantidade", OracleDbType.Int32).Value = produto.QuantidadeEstoque;
            command.Parameters.Add("idCategoria", OracleDbType.Int32).Value = produto.IdCategoria;
            command.Parameters.Add("id", OracleDbType.Int32).Value = produto.IdProduto;

            command.ExecuteNonQuery();
        }
    }

    // DELETE
    public static void ExcluirProduto(int idProduto)
    {
        using (OracleConnection connection = OracleDbConnection.GetConnection())
        {
            string sql = "DELETE FROM produtos WHERE id_produto = :id";
            OracleCommand command = new OracleCommand(sql, connection);
            command.Parameters.Add("id", OracleDbType.Int32).Value = idProduto;
            command.ExecuteNonQuery();
        }
    }
}