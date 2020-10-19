using Unicus.Acad.Dominio.Shared;

namespace Unicus.Acad.Dominio.Disciplinas
{
    public class Disciplina : Agregado<int>
    {
        public virtual string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
