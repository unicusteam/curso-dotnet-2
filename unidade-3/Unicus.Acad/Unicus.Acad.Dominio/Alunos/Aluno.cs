using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Unicus.Acad.Dominio.Shared;

namespace Unicus.Acad.Dominio
{
    public class Aluno : Agregado<int>
    {
        public virtual string Nome { get; set; }
        public virtual Sexo Sexo { get; set; }

        public override IList<ValidationResult> Validar()
        {
            var result = new List<ValidationResult>();

            if (string.IsNullOrEmpty(Nome))
            {
                result.Add(new ValidationResult("O nome é obrigatório"));
            }

            if (Sexo == 0)
            {
                result.Add(new ValidationResult("O sexo é obrigatório"));
            }

            return result;
        }
    }
}
