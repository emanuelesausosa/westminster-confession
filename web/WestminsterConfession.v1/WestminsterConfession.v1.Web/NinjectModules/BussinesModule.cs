using Ninject.Modules;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WestminsterConfession.v1.Bussines.Managers;
using WestminsterConfession.v1.DB;

namespace WestminsterConfession.v1.Web.NinjectModules
{
    public class BussinesModule
        : NinjectModule
    {
        public override void Load()
        {
            Bind<CharperManager>().ToSelf().InRequestScope();
        }
    }
}