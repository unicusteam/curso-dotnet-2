using Unicus.Acad.Aplicacao.Shared;
using Unicus.Acad.Dominio.Turmas;
using Unicus.Acad.Infraestrutura.Repositorios;

namespace Unicus.Acad.Aplicacao
{
    public class TurmaAppServico : AppServico<Turma, ITurmaRepositorio, int>
    {
        protected override void Initicializar()
        {
            repositorio = new TurmaRepositorio();
        }
    }
}
