using FluentNHibernate.Mapping;
using Unicus.Acad.Dominio;

namespace Unicus.Acad.Infraestrutura.Mapeamentos
{
    public class AlunoMap : ClassMap<Aluno>
    {
        public AlunoMap()
        {
            Id(c => c.Id).GeneratedBy.Native();
            Map(c => c.Nome).Length(100).Not.Nullable();
            Map(c => c.Sexo).CustomType<Sexo>();
        }
    }
}
