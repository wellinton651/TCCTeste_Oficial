using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProtótipoGerenciamentoEscola
{

        public static class ConexaoBD
        {
            private static string servidor = "localhost";        // ou IP
            private static string bancoDados = "agenda_escolar";
            private static string usuario = "root";              // seu usuário MySQL
            private static string senha = "daitogito651";                    // sua senha do MySQL
            private static string porta = "3306";

            private static string stringConexao = $"server={servidor};port={porta};database={bancoDados};uid={usuario};pwd={senha};SslMode=none;";

            public static MySqlConnection ObterConexao()
            {
                return new MySqlConnection(stringConexao);
            }
        }
    }


