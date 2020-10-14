using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Unicus.Acad.Dominio.Shared;

namespace Unicus.Acad.Dominio
{
    public class Aluno : Agregado<int>
    {
        public virtual string Nome { get; set; }

        public override IList<ValidationResult> Validar()
        {
            var result = new List<ValidationResult>();

            if (string.IsNullOrEmpty(Nome))
            {
                result.Add(new ValidationResult("O nome é obrigatório"));
            }

            return result;
        }
    }
}
