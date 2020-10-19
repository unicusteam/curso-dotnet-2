using System.Collections.Generic;
using Unicus.Acad.Dominio.Shared;

namespace Unicus.Acad.Dominio.Cursos
{
    public class Curso : Agregado<int>
    {
        public virtual string Nome { get; set; }
        public virtual IList<CursoDisciplina> Disciplinas { get; set; }

        public Curso()
        {
            Disciplinas = new List<CursoDisciplina>();
        }

        public virtual void AdicionarDisciplina(CursoDisciplina cursoDisciplina)
        {
            cursoDisciplina.Curso = this;
            Disciplinas.Add(cursoDisciplina);
        }
    }
}
