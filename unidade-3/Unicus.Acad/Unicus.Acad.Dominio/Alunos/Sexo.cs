using System.ComponentModel.DataAnnotations;

namespace Unicus.Acad.Dominio
{
    public enum Sexo
    {
        [Display(Name = "MASCULINO")]
        Masculino = 1,
        [Display(Name = "FEMINO")]
        Feminino = 2
    }
}