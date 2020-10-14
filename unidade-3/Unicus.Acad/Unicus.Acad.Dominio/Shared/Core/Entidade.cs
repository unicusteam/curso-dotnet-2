using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Unicus.Acad.Dominio.Shared
{
    public abstract class Entidade<TId>
    {
        public virtual TId Id { get; set; }
        public abstract IList<ValidationResult> Validar();
    }
}
