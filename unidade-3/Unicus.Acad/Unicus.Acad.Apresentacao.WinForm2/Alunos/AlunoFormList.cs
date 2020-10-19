using System.Windows.Forms;
using Unicus.Acad.Aplicacao;
using Unicus.Acad.Dominio;

namespace Unicus.Acad.Apresentacao.WinForm2.Alunos
{
    public partial class AlunoFormList : Form
    {
        private AlunoAppServico alunoAppServico;

        public AlunoFormList()
        {
            InitializeComponent();
            alunoAppServico = new AlunoAppServico();
            CarregarTodos();
        }

        private void CarregarTodos()
        {
            alunoBindingSource.DataSource = alunoAppServico.ObterTodos();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            InserirOuEditarAluno(new Aluno());
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            InserirOuEditarAluno(alunoDataGridView.GetCurrentRow<Aluno>());
        }

        private void InserirOuEditarAluno(Aluno aluno)
        {
            AlunoFormEdit alunoFormEdit = new AlunoFormEdit();
            alunoFormEdit.Aluno = aluno;
            if (alunoFormEdit.ShowDialog() == DialogResult.OK)
            {
                CarregarTodos();
            }
        }
    }
}
