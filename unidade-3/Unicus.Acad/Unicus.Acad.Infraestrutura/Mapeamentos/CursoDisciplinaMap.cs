using FluentNHibernate.Mapping;
using Unicus.Acad.Dominio.Cursos;

namespace Unicus.Acad.Infraestrutura.Mapeamentos
{
    public class CursoDisciplinaMap : ClassMap<CursoDisciplina>
    {
        public CursoDisciplinaMap()
        {
            Id(c => c.Id).GeneratedBy.Native();

            References(c => c.Curso).Column("CursoId").Not.Nullable();
            References(c => c.Disciplina).Column("DisciplinaId").Not.Nullable();

            Map(c => c.CargaHoraria)
                .Not.Nullable();            
        }
    }
}
