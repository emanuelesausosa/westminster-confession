using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using WestminsterConfession.v1.DB;

namespace WestminsterConfession.v1.WebApp.Infraestructure
{
    public class AppDbFactory :
        IDBFactory
    {
        public DbConnection CreateDbConnection()
        {
            throw new NotImplementedException();
        }

        public TDbContext CreateDbContext<TDbContext>() where TDbContext : CoreDBContext
        {
            var dbCtxType = typeof(TDbContext);
            return new CoreDBContext() as TDbContext;
        }

        public TDbContext CreateDbContext<TDbContext>(DbConnection dbConnection) where TDbContext : CoreDBContext
        {
            var dbCtxType = typeof(TDbContext);
            return new CoreDBContext(dbConnection) as TDbContext;
        }
    }
}