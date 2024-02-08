using MySql.Data.MySqlClient;

namespace ListaCarrosAPI.DAO
{
    public class ConnectionFactory
    {
         public static MySqlConnection Build()
        {
            return new MySqlConnection("Server=localhost;Database=Carro;Uid=root;Pwd=root;");
        }
    }
}
