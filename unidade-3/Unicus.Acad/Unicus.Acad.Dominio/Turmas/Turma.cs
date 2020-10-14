using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Unicus.Acad.Dominio.Shared;

namespace Unicus.Acad.Dominio.Turmas
{
    public class Turma : Agregado<int>
    {
        public virtual string Nome { get; set; }

        public override IList<ValidationResult> Validar()
        {
            throw new System.NotImplementedException();
        }
    }
}
