using FluentNHibernate.Mapping;
using Unicus.Acad.Dominio.Turmas;

namespace Unicus.Acad.Infraestrutura.Mapeamentos
{
    public class TurmaMap : ClassMap<Turma>
    {
        public TurmaMap()
        {
            Id(c => c.Id).GeneratedBy.Native();
            Map(c => c.Nome).Length(100).Not.Nullable();         
        }
    }
}
