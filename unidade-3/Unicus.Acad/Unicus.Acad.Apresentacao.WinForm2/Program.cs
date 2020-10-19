using System;
using System.Windows.Forms;
using Unicus.Acad.Apresentacao.WinForm2.Cursos;
using Unicus.Acad.Infraestrutura;

namespace Unicus.Acad.Apresentacao.WinForm2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            NhibernateHelper.Configurar();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CursoFormEdit());
        }
    }
}
