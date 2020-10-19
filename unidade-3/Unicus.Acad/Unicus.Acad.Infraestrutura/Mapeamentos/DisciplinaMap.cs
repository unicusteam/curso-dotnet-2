using FluentNHibernate.Mapping;
using Unicus.Acad.Dominio.Disciplinas;

namespace Unicus.Acad.Infraestrutura.Mapeamentos
{
    public class DisciplinaMap : ClassMap<Disciplina>
    {
        public DisciplinaMap()
        {
            Id(c => c.Id).GeneratedBy.Native();
            Map(c => c.Nome).Length(100).Not.Nullable();         
        }
    }
}
