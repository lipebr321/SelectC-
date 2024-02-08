using ListaCarrosAPI.DTOs;
using MySql.Data.MySqlClient;

namespace ListaCarrosAPI.DAO
{
    public class CarroDAO
    {
        public List<CarroDTO> ListarCarros()
        {
            var conexao = ConnectionFactory.Build();
            conexao.Open();

            var query = "SELECT*FROM carros";

            var comando = new MySqlCommand(query, conexao);
            var dataReader = comando.ExecuteReader();

            var carros = new List<CarroDTO>();

            while (dataReader.Read())
            {
                var carro = new CarroDTO();
                carro.ID = int.Parse(dataReader["ID"].ToString());
                carro.Nome = dataReader["Nome"].ToString();
                carro.Marca = dataReader["Marca"].ToString();
                carro.Descricao = dataReader["Descricao"].ToString();
                carro.Ano = int.Parse(dataReader["Ano"].ToString());

                carros.Add(carro);
            }
            conexao.Close();

            return carros;
        }
    }
}
