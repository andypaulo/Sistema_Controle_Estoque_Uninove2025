using Oracle.ManagedDataAccess.Client;
using System.Configuration;

public class OracleDbConnection
{
    private static readonly string connectionString =
        ConfigurationManager.ConnectionStrings["OracleDB"].ConnectionString;

    public static OracleConnection GetConnection()
    {
        var connection = new OracleConnection(connectionString);

        try
        {
            connection.Open();
            return connection;
        }
        catch (OracleException ex)
        {
            string errorDetails = $"Code: {ex.ErrorCode}\n" +
                                $"Message: {ex.Message}\n" +
                                $"Source: {ex.Source}\n" +
                                $"Procedure: {ex.Procedure}\n" +
                                $"LineNumber: {ex.Number}";

            MessageBox.Show($"Erro de conexão Oracle:\n{errorDetails}",
                          "Erro de Banco de Dados",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
            return null;
        }
    }
}