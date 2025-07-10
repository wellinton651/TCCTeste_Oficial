using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtótipoGerenciamentoEscola
{
    internal class Endereco
    {       
            public int Id { get; set; }
            public string Cep { get; set; }
            public string Rua { get; set; }
            public string Numero { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
            public string Complemento { get; set; }

        public static int CadastrarEndereco(Endereco end)
        {
            using var conn = ConexaoBD.ObterConexao();
            var cmd = new MySqlCommand(@"INSERT INTO Endereco (cep, rua, numero, bairro, cidade, estado, complemento) VALUES (@cep, @rua, @numero, @bairro, @cidade, @estado, @complemento);SELECT LAST_INSERT_ID();", conn);
            cmd.Parameters.AddWithValue("@cep", end.Cep);
            cmd.Parameters.AddWithValue("@rua", end.Rua);
            cmd.Parameters.AddWithValue("@numero", end.Numero);
            cmd.Parameters.AddWithValue("@bairro", end.Bairro);
            cmd.Parameters.AddWithValue("@cidade", end.Cidade);
            cmd.Parameters.AddWithValue("@estado", end.Estado);
            cmd.Parameters.AddWithValue("@complemento", end.Complemento);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
