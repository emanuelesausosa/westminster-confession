using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestminsterConfession.v1.DB;

namespace WestminsterConfession.v1.Bussines
{
    public abstract class Manager
    {
        private readonly IDBFactory _dbFactory;
        protected Manager(IDBFactory dBFactory)
        {
            _dbFactory = dBFactory;
        }        

        protected CoreDBContext NewCoreDbContext(DbConnection dbConnection = null)
        {
            return dbConnection != null ?
                _dbFactory.CreateDbContext<CoreDBContext>(dbConnection) :
                _dbFactory.CreateDbContext<CoreDBContext>();
        }
    }
}
