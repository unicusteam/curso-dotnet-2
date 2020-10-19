using System;
using System.Windows.Forms;
using Unicus.Acad.Apresentacao.WinForm2.Alunos;

namespace Unicus.Acad.Apresentacao.WinForm2
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunoFormList alunoFormList = new AlunoFormList();
            alunoFormList.Show();
        }
    }
}
