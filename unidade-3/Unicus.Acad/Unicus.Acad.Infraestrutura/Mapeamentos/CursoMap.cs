using FluentNHibernate.Mapping;
using Unicus.Acad.Dominio.Cursos;

namespace Unicus.Acad.Infraestrutura.Mapeamentos
{
    public class CursoMap : ClassMap<Curso>
    {
        public CursoMap()
        {
            Id(c => c.Id).GeneratedBy.Native();
            Map(c => c.Nome).Length(100).Not.Nullable();

            HasMany(c => c.Disciplinas)
                .Inverse().Cascade.AllDeleteOrphan();
        }
    }
}
