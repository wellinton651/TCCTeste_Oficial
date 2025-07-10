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
    public partial class TelaResponsavel : Form
    {
        public TelaResponsavel()
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
        }

        private void btnEndContato_Click(object sender, EventArgs e)
        {
            TelaEndereco telaEndereco = new TelaEndereco();
            telaEndereco.ShowDialog();
            // Vai para a tela de cadastro de endereço e contato
        }

        private void btnFichaCadastral_Click(object sender, EventArgs e)
        {

        }

        private void btnTurmas_Click(object sender, EventArgs e)
        {
            TelaTurma telaTurma = new TelaTurma();
            telaTurma.ShowDialog();
            // Vai para a tela de cadastro de turmas
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }
    }
}
