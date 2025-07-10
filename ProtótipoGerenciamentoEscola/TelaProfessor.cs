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
    public partial class TelaProfessor : Form
    {
        public TelaProfessor()
        {
            InitializeComponent();
        }

        private void btnFichaCadastral_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaAluno = new TelaPrincipal();
            telaAluno.ShowDialog();
            // Vai para a tela de ficha cadastral que seria a mesma tela de cadastro de aluno
        }

        private void btnTurmas_Click(object sender, EventArgs e)
        {
            TelaTurma telaTurma = new TelaTurma();
            telaTurma.ShowDialog();
            // Vai para a tela de cadastro de turmas
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
