using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtótipoGerenciamentoEscola
{
    internal class Contato
    {
            public int Id { get; set; }
            public string TelefoneCelular { get; set; }
            public string TelefoneResidencial { get; set; }
            public string Email { get; set; }

        public static int CadastrarContato(Contato contato)
        {
            using var conn = ConexaoBD.ObterConexao();
            var cmd = new MySqlCommand(@"INSERT INTO Contato (telefone_celular, telefone_residencial, email)VALUES (@celular, @residencial, @email);SELECT LAST_INSERT_ID();", conn);
            cmd.Parameters.AddWithValue("@celular", contato.TelefoneCelular);
            cmd.Parameters.AddWithValue("@residencial", contato.TelefoneResidencial);
            cmd.Parameters.AddWithValue("@email", contato.Email);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
