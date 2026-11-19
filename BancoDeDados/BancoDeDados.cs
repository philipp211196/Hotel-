using MySqlConnector;

namespace Hotel.BancoDeDados
{
    public static class BancoDeDados
    {
        private static readonly string stringConexao =
            "Server=" + (Environment.GetEnvironmentVariable("HOTEL_MYSQL_SERVER") ?? "localhost") + ";" +
            "Port=" + (Environment.GetEnvironmentVariable("HOTEL_MYSQL_PORT") ?? "3306") + ";" +
            "Database=" + (Environment.GetEnvironmentVariable("HOTEL_MYSQL_DATABASE") ?? "vila_serena") + ";" +
            "User ID=" + (Environment.GetEnvironmentVariable("HOTEL_MYSQL_USER") ?? "root") + ";" +
            "Password=" + (Environment.GetEnvironmentVariable("HOTEL_MYSQL_PASSWORD") ?? "") + ";";

        public static MySqlConnection Conectar() => new MySqlConnection(stringConexao);
    }
}
