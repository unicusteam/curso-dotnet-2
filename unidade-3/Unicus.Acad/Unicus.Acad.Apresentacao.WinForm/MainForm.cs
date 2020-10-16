using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Unicus.Acad.Dominio;

namespace Unicus.Acad.Apresentacao.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
       
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           //MessageBox.Show(e.KeyData.ToString());
        }
    }   
}
