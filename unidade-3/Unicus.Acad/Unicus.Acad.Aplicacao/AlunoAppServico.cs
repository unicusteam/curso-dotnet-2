using Unicus.Acad.Aplicacao.Shared;
using Unicus.Acad.Dominio;
using Unicus.Acad.Dominio.Alunos;
using Unicus.Acad.Infraestrutura.Repositorios;

namespace Unicus.Acad.Aplicacao
{
    public class AlunoAppServico : AppServico<Aluno, IAlunoRepositorio, int>
    {
        protected override void Initicializar()
        {
            repositorio = new AlunoRepositorio();
        }
    }
}
