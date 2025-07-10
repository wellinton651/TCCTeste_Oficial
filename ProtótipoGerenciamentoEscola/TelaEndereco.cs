using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtótipoGerenciamentoEscola
{
    public partial class TelaEndereco : Form
    {
        public TelaEndereco()
        {
            InitializeComponent();
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaEndereco telaEndereco = new TelaEndereco();
            telaEndereco.ShowDialog();
            // Vai para a tela de cadastro de endereço e contato
        }

        private void btnTelaResponsaveis_Click(object sender, EventArgs e)
        {
            TelaResponsavel telaResponsavel = new TelaResponsavel();
            telaResponsavel.ShowDialog();
            // Vai para a tela de cadastro de responsável
        }

        private void btnTelaAluno_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaAluno = new TelaPrincipal();
            telaAluno.ShowDialog();
            // Vai para a tela de cadastro de aluno
        }

        private void btnTurmas_Click(object sender, EventArgs e)
        {
            TelaTurma telaTurma = new TelaTurma();
            telaTurma.ShowDialog();
            // Vai para a tela de cadastro de turmas
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

        }
    }
}
