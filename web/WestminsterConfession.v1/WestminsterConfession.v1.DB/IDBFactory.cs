using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestminsterConfession.v1.DB
{
    public interface IDBFactory
    {
        TDbContext CreateDbContext<TDbContext>()
            where TDbContext : CoreDBContext;

        TDbContext CreateDbContext<TDbContext>(DbConnection dbConnection)
            where TDbContext : CoreDBContext;

        DbConnection CreateDbConnection();
    }
}
