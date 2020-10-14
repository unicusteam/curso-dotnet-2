using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System.Reflection;

namespace Unicus.Acad.Infraestrutura
{
    public static class NhibernateHelper
    {
        private static ISessionFactory sessionFactory;

        public static void Configurar()
        {
            string connecString = "Data Source=DESKTOP-ALKRESO;Initial Catalog=CURSODOTNET;Integrated Security=True";

            MsSqlConfiguration configuracao = MsSqlConfiguration.MsSql2012
                .ConnectionString(connecString)
                .ShowSql();

            FluentConfiguration fluentConfig = Fluently
                .Configure()
                .Database(configuracao)
                .Mappings(mappingConfiguration =>
                {                    
                    mappingConfiguration.FluentMappings.AddFromAssembly(Assembly.Load("Unicus.Acad.Infraestrutura"));
                })
            .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true));

            sessionFactory = fluentConfig.BuildSessionFactory();           
        }

        public static ISession AbrirSessao()
        {
            return sessionFactory.OpenSession();
        }
    }
}
