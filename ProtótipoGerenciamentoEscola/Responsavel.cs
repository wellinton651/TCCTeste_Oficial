using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtótipoGerenciamentoEscola
{
    internal class Responsavel
    {
            public int Id { get; set; }
            public string NomeCompleto { get; set; }
            public string Parentesco { get; set; }
            public DateTime? DataNascimento { get; set; }
            public string Nacionalidade { get; set; }
            public string CPF { get; set; }
            public string EstadoCivil { get; set; }
            public string Profissao { get; set; }

            public int IdEndereco { get; set; }
            public int IdContato { get; set; }


        public static void CadastrarResponsavel(Responsavel resp)
        {
            using var conn = ConexaoBD.ObterConexao();
            var cmd = new MySqlCommand(@"INSERT INTO Responsavel(nome_completo, parentesco, data_nascimento, nacionalidade, cpf, estado_civil, profissao, id_endereco, id_contato) VALUES (@nome, @parentesco, @nasc, @nac, @cpf, @estado, @prof, @idend, @idcontato)", conn);

            cmd.Parameters.AddWithValue("@nome", resp.NomeCompleto);
            cmd.Parameters.AddWithValue("@parentesco", resp.Parentesco);
            cmd.Parameters.AddWithValue("@nasc", resp.DataNascimento);
            cmd.Parameters.AddWithValue("@nac", resp.Nacionalidade);
            cmd.Parameters.AddWithValue("@cpf", resp.CPF);
            cmd.Parameters.AddWithValue("@estado", resp.EstadoCivil);
            cmd.Parameters.AddWithValue("@prof", resp.Profissao);
            cmd.Parameters.AddWithValue("@idend", resp.IdEndereco);
            cmd.Parameters.AddWithValue("@idcontato", resp.IdContato);

            cmd.ExecuteNonQuery();
        }
    }
}
