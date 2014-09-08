using FluentNHibernate.Cfg;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
using System.Reflection;

namespace NhibernateTuto
{
    public static class NHibernateHelper
    {
        public static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure().Database(
                MySQLConfiguration.Standard.
                ConnectionString(c => c.FromConnectionStringWithKey("testconnectionstring"))).
                Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>()).
                ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true)).BuildSessionFactory();
        }

        public static ISessionFactory CreateSessionFactory2()
        {
            try
            {
                string connectionstring = "Data Source=C:/sqllite/VODDB.db;Version=3;";

                return Fluently.Configure()
                    .Database(SQLiteConfiguration.Standard.ConnectionString(connectionstring))
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                    .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true))
                    .BuildSessionFactory();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
