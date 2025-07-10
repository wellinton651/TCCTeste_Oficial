using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtótipoGerenciamentoEscola
{
    using global::ProtótipoGerenciamentoEscola.ProtótipoGerenciamentoEscola;
    using System;

    namespace ProtótipoGerenciamentoEscola
    {
        
        public class Aluno
        {
            // Propriedades
                public int IdAluno { get; set; }
                public string NomeCompleto { get; set; }
                public DateTime DataNascimento { get; set; }
                public string Nacionalidade { get; set; }
                public string CPF { get; set; }
                public string CartaoSUS { get; set; }
                public bool PessoaComDeficiencia { get; set; }
                public DateTime DataMatricula { get; set; } = DateTime.Now;
                public DateTime? ValidadeMatricula { get; set; } = DateTime.Now.AddYears(1);
                public string FotoUrl { get; set; }
                public int? IdEndereco { get; set; } = null;
                public int? IdContato { get; set; } = null;
            



            // Construtor padrão
            public Aluno() { }

            // Construtor com todos os campos
            public Aluno(int idAluno, string nomeCompleto, DateTime dataNascimento, string nacionalidade,
                         string cpf, string cartaoSUS, bool pessoaComDeficiencia, DateTime dataMatricula,
                         DateTime? validadeMatricula, string fotoUrl, int? idEndereco, int? idContato)
            {
                IdAluno = idAluno;
                NomeCompleto = nomeCompleto;
                DataNascimento = dataNascimento;
                Nacionalidade = nacionalidade;
                CPF = cpf;
                CartaoSUS = cartaoSUS;
                PessoaComDeficiencia = pessoaComDeficiencia;
                DataMatricula = dataMatricula;
                ValidadeMatricula = validadeMatricula;
                FotoUrl = fotoUrl;
                IdEndereco = idEndereco;
                IdContato = idContato;
            }
        }
    }
        public class AlunoDAO
        {
        public void Inserir(Aluno aluno)
        {
            using (var conexao = ConexaoBD.ObterConexao())
            {
                conexao.Open();

                string sql = @"INSERT INTO Aluno 
                            (nome_completo, data_nascimento, nacionalidade, cpf, cartao_sus, pessoa_com_deficiencia, data_matricula, validade_matricula, foto_url, id_endereco, id_contato)
                            VALUES 
                            (@nome, @nasc, @nacionalidade, @cpf, @sus, @deficiencia, @matricula, @validade, @foto, @endereco, @contato)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", aluno.NomeCompleto);
                    cmd.Parameters.AddWithValue("@nasc", aluno.DataNascimento);
                    cmd.Parameters.AddWithValue("@nacionalidade", aluno.Nacionalidade);
                    cmd.Parameters.AddWithValue("@cpf", aluno.CPF);
                    cmd.Parameters.AddWithValue("@sus", aluno.CartaoSUS);
                    cmd.Parameters.AddWithValue("@deficiencia", aluno.PessoaComDeficiencia);
                    cmd.Parameters.AddWithValue("@matricula", aluno.DataMatricula);
                    cmd.Parameters.AddWithValue("@validade", aluno.ValidadeMatricula);
                    cmd.Parameters.AddWithValue("@foto", aluno.FotoUrl);
                    cmd.Parameters.AddWithValue("@endereco", aluno.IdEndereco);
                    cmd.Parameters.AddWithValue("@contato", aluno.IdContato);

                    cmd.ExecuteNonQuery();
                }

                // opcional: obter o último ID inserido
                aluno.IdAluno = (int)new MySqlCommand("SELECT LAST_INSERT_ID();", conexao).ExecuteScalar();
            }
        }

        // SELECT (todos)
        public List<Aluno> Listar()
        {
            List<Aluno> lista = new List<Aluno>();

            using (var conexao = ConexaoBD.ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM Aluno ORDER BY nome_completo";

                using (var cmd = new MySqlCommand(sql, conexao))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Aluno aluno = new Aluno
                        {
                            IdAluno = Convert.ToInt32(reader["id_aluno"]),
                            NomeCompleto = reader["nome_completo"].ToString(),
                            DataNascimento = Convert.ToDateTime(reader["data_nascimento"]),
                            Nacionalidade = reader["nacionalidade"]?.ToString(),
                            CPF = reader["cpf"]?.ToString(),
                            CartaoSUS = reader["cartao_sus"]?.ToString(),
                            PessoaComDeficiencia = Convert.ToBoolean(reader["pessoa_com_deficiencia"]),
                            DataMatricula = Convert.ToDateTime(reader["data_matricula"]),
                            ValidadeMatricula = reader["validade_matricula"] == DBNull.Value ? null : Convert.ToDateTime(reader["validade_matricula"]),
                            FotoUrl = reader["foto_url"]?.ToString(),
                            IdEndereco = reader["id_endereco"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["id_endereco"]),
                            IdContato = reader["id_contato"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["id_contato"])
                        };

                        lista.Add(aluno);
                    }
                }
            }

            return lista;
        }

        // UPDATE
        public void Atualizar(Aluno aluno)
        {
            using (var conexao = ConexaoBD.ObterConexao())
            {
                conexao.Open();

                string sql = @"UPDATE Aluno SET
                            nome_completo = @nome,
                            data_nascimento = @nasc,
                            nacionalidade = @nacionalidade,
                            cpf = @cpf,
                            cartao_sus = @sus,
                            pessoa_com_deficiencia = @deficiencia,
                            data_matricula = @matricula,
                            validade_matricula = @validade,
                            foto_url = @foto,
                            id_endereco = @endereco,
                            id_contato = @contato
                        WHERE id_aluno = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", aluno.IdAluno);
                    cmd.Parameters.AddWithValue("@nome", aluno.NomeCompleto);
                    cmd.Parameters.AddWithValue("@nasc", aluno.DataNascimento);
                    cmd.Parameters.AddWithValue("@nacionalidade", aluno.Nacionalidade);
                    cmd.Parameters.AddWithValue("@cpf", aluno.CPF);
                    cmd.Parameters.AddWithValue("@sus", aluno.CartaoSUS);
                    cmd.Parameters.AddWithValue("@deficiencia", aluno.PessoaComDeficiencia);
                    cmd.Parameters.AddWithValue("@matricula", aluno.DataMatricula);
                    cmd.Parameters.AddWithValue("@validade", aluno.ValidadeMatricula);
                    cmd.Parameters.AddWithValue("@foto", aluno.FotoUrl);
                    cmd.Parameters.AddWithValue("@endereco", aluno.IdEndereco);
                    cmd.Parameters.AddWithValue("@contato", aluno.IdContato);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE
        public void Excluir(int idAluno)
        {
            using (var conexao = ConexaoBD.ObterConexao())
            {
                conexao.Open();
                string sql = "DELETE FROM Aluno WHERE id_aluno = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", idAluno);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}