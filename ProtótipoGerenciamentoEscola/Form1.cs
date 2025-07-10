using MySql.Data.MySqlClient;
using ProtótipoGerenciamentoEscola.ProtótipoGerenciamentoEscola;
using System.Data;

namespace ProtótipoGerenciamentoEscola
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }


        private void pbFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTelaAluno_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaAluno = new TelaPrincipal();
            telaAluno.ShowDialog();
            // Vai para a tela de cadastro de aluno
        }

        private void btnTelaResponsaveis_Click(object sender, EventArgs e)
        {
            TelaResponsavel telaResponsavel = new TelaResponsavel();
            telaResponsavel.ShowDialog();
            // Vai para a tela de cadastro de responsável
        }

        private void btnTelaEndContato_Click(object sender, EventArgs e)
        {
            TelaEndereco telaEndereco = new TelaEndereco();
            telaEndereco.ShowDialog();
            // Vai para a tela de cadastro de endereço e contato
        }

        private void btnTurmas_Click(object sender, EventArgs e)
        {
            TelaTurma telaTurma = new TelaTurma();
            telaTurma.ShowDialog();
            // Vai para a tela de cadastro de turmas
        }

        private void btnFichaCadastral_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaAluno = new TelaPrincipal();
            telaAluno.ShowDialog();
            // Vai para a tela de ficha cadastral que seria a mesma tela de cadastro de aluno
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtNacionalidade.Clear();
            mtxtNascimento.Clear();
            mtxtCPF.Clear();
            mtxtSUS.Clear();
            checkDeficiencia.Checked = false;
            txtMatricula.Clear();
            txtDTMatricula.Clear();
            txtValMatricula.Clear();
            cbTurmas.SelectedIndex = -1;
            pbFotoAluno.Image = null;
        }

        private void CarregarAlunos()
        {
            AlunoDAO dao = new AlunoDAO();
            List<Aluno> lista = dao.Listar();

            dgvAlunos.DataSource = lista; // seu DataGridView
        }


        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                // Validações básicas


                Aluno aluno = new Aluno
                {
                    NomeCompleto = txtNome.Text.Trim(),
                    Nacionalidade = txtNacionalidade.Text.Trim(),
                    DataNascimento = DateTime.ParseExact(mtxtNascimento.Text, "dd/MM/yyyy", null),
                    CPF = mtxtCPF.Text,
                    CartaoSUS = mtxtSUS.Text,
                    PessoaComDeficiencia = checkDeficiencia.Checked,



                };

                AlunoDAO dao = new AlunoDAO();
                dao.Inserir(aluno);

                // Atualiza os campos visuais após cadastro
                txtMatricula.Text = aluno.IdAluno.ToString(); // pode preencher depois com SELECT
                txtDTMatricula.Text = aluno.DataMatricula.ToShortDateString();
                txtValMatricula.Text = aluno.ValidadeMatricula?.ToShortDateString();

                MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Data de nascimento inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar aluno: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ListarAlunos()
        {
            try
            {
                using (MySqlConnection conexao = ConexaoBD.ObterConexao())
                {
                    conexao.Open();
                    string sql = @"SELECT 
                                id_aluno, 
                                nome_completo, 
                                DATE_FORMAT(data_nascimento, '%d/%m/%Y') AS data_nascimento, 
                                nacionalidade, 
                                cpf, 
                                cartao_sus, 
                                pessoa_com_deficiencia,
                                DATE_FORMAT(data_matricula, '%d/%m/%Y') AS data_matricula, 
                                DATE_FORMAT(validade_matricula, '%d/%m/%Y') AS validade_matricula
                            FROM Aluno";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable tabela = new DataTable();
                    da.Fill(tabela);

                    dgvAlunos.DataSource = tabela;

                    // Configura os nomes das colunas
                    dgvAlunos.Columns["id_aluno"].HeaderText = "ID";
                    dgvAlunos.Columns["nome_completo"].HeaderText = "Nome";
                    dgvAlunos.Columns["data_nascimento"].HeaderText = "Nascimento";
                    dgvAlunos.Columns["nacionalidade"].HeaderText = "Nacionalidade";
                    dgvAlunos.Columns["cpf"].HeaderText = "CPF";
                    dgvAlunos.Columns["cartao_sus"].HeaderText = "Cartão SUS";
                    dgvAlunos.Columns["pessoa_com_deficiencia"].HeaderText = "PCD";
                    dgvAlunos.Columns["data_matricula"].HeaderText = "Data Matrícula";
                    dgvAlunos.Columns["validade_matricula"].HeaderText = "Val. Matrícula";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar alunos: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarAlunos();
        }
    }
}
