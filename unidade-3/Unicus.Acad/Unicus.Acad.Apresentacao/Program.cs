using Unicus.Acad.Apresentacao.Controllers;
using Unicus.Acad.Infraestrutura;

namespace Unicus.Acad.Apresentacao
{
    class Program
    {
        static void Main(string[] args)
        {
            NhibernateHelper.Configurar();
            AlunoController alunoController = new AlunoController();
            alunoController.Cadastrar();
        }
    }
}
