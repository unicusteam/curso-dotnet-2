using Unicus.Acad.Dominio.Disciplinas;
using Unicus.Acad.Dominio.Shared;

namespace Unicus.Acad.Dominio.Cursos
{
    public class CursoDisciplina : Entidade<int>
    {
        public virtual Curso Curso { get; set; }
        public virtual Disciplina Disciplina { get; set; }
        public virtual decimal CargaHoraria { get; set; }
    }
}