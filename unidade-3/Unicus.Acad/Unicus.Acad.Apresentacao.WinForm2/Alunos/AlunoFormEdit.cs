﻿using DevExpress.XtraEditors.Controls;
using System;
using System.Windows.Forms;
using Unicus.Acad.Aplicacao;
using Unicus.Acad.Dominio;

namespace Unicus.Acad.Apresentacao.WinForm2.Alunos
{
    public partial class AlunoFormEdit : Form
    {
        private readonly AlunoAppServico alunoAppServico;
        private readonly TurmaAppServico turmaAppServico;

        public Aluno Aluno
        {
            set { alunoBindingSource.DataSource = value; }
            get { return alunoBindingSource.DataSource as Aluno; }
        }

        public AlunoFormEdit()
        {
            InitializeComponent();
            alunoAppServico = new AlunoAppServico();
            turmaAppServico = new TurmaAppServico();

            var turmas = turmaAppServico.ObterTodos();

            foreach (var turma in turmas)
            {
                turmaComboBox.Items.Add(turma);
            }
            
            sexoComboBox.AddEnum<Sexo>();     
        }

        private void confirmarButton_Click(object sender, EventArgs e)
        {
            var resultado = alunoAppServico.Salvar(Aluno);

            if (resultado.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, resultado));
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Confirmar()
        {
            var aluno = alunoBindingSource.DataSource as Aluno;
            var nome = aluno.Nome;
            MessageBox.Show(aluno.Nome);
        }

        private void nomeTextBox_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void nomeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var aluno = alunoBindingSource.DataSource as Aluno;
            var nome = aluno.Nome;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                Confirmar();
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
