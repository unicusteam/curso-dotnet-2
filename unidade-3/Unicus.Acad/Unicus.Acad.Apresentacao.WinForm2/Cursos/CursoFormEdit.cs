using System.Collections.Generic;
using System.Windows.Forms;
using Unicus.Acad.Dominio.Cursos;
using Unicus.Acad.Dominio.Disciplinas;

namespace Unicus.Acad.Apresentacao.WinForm2.Cursos
{
    public partial class CursoFormEdit : Form
    {
        public CursoFormEdit()
        {
            InitializeComponent();
            cursoBindingSource.DataSource = new Curso()
            {
                Nome = "Ciências da Computação"
            };

            comboBox1.DataSource = new List<Disciplina>() {
             new Disciplina() { Nome = "Algoritimos" },
                    new Disciplina() { Nome = "Orientação a objeto" },
                    new Disciplina() { Nome = "Análise e projeto de sistemas" },
                    new Disciplina() { Nome = "Calculo I" },
                    new Disciplina() { Nome = "Calculo II" },
                    new Disciplina() { Nome = "Calculo III" }
            };

            InitializarDisciplina();
        }

        private void InitializarDisciplina()
        {
            cursoDisciplinaBindingSource.DataSource = new CursoDisciplina();
            cursoDisciplinaBindingSource.ResetBindings(false);
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var curso = cursoBindingSource.DataSource as Curso;

            var cursoDisciplina = cursoDisciplinaBindingSource.GetDataSource<CursoDisciplina>();

            curso.AdicionarDisciplina(cursoDisciplina);

            cursoBindingSource.ResetBindings(false);
            InitializarDisciplina();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            //var disciplina = disciplinasDataGridView.GetCurrentRow<Disciplina>();
            //var curso = cursoBindingSource.DataSource as Curso;
            //curso.Disciplinas.Remove(disciplina);
            //cursoBindingSource.ResetBindings(false);

        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            var cursoDisciplina = disciplinasDataGridView.GetCurrentRow<CursoDisciplina>();
            cursoDisciplinaBindingSource.DataSource = cursoDisciplina;
            cursoDisciplinaBindingSource.ResetBindings(false);
        }

        private void comboBox2_SelectedValueChanged(object sender, System.EventArgs e)
        {
            var curso = comboBox2.SelectedItem as Curso;
            curso.Disciplinas.Clear();

        }
    }
}
