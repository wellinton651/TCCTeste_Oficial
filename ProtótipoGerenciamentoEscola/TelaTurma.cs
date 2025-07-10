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
    public partial class TelaTurma : Form
    {
        public TelaTurma()
        {
            InitializeComponent();
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFichaCadastral_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaAluno = new TelaPrincipal();
            telaAluno.ShowDialog();
            // Vai para a tela de ficha cadastral que seria a mesma tela de cadastro de aluno
        }

        private void btnTelaProfessor_Click(object sender, EventArgs e)
        {
            TelaProfessor telaProfessor = new TelaProfessor();
            telaProfessor.Show();
            // Vai para a tela de professor
        }
    }
}
