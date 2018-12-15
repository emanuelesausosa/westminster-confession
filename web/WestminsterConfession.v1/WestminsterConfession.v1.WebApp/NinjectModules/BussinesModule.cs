using Ninject.Modules;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WestminsterConfession.v1.Bussines.Managers;

namespace WestminsterConfession.v1.WebApp.NinjectModules
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