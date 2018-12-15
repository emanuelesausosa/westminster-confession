using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Ninject;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using Unity;
using Unity.Lifetime;
using WestminsterConfession.v1.Bussines.Managers;
using WestminsterConfession.v1.DB;
using WestminsterConfession.v1.WebApp.Infraestructure;
using WestminsterConfession.v1.WebApp.NinjectModules;

[assembly: OwinStartup(typeof(WestminsterConfession.v1.WebApp.Startup))]

namespace WestminsterConfession.v1.WebApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var httpConfiguration = new HttpConfiguration();
            ConfigureWebApi(httpConfiguration);
            app.UseWebApi(httpConfiguration);

            var kernel = CreateKernel();            
            app.UseNinjectMiddleware(() => kernel).UseNinjectWebApi(httpConfiguration);

        }

        public static void ConfigureWebApi(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);           
        }

        public static IKernel CreateKernel()
        {
            var kernel = new StandardKernel(new BussinesModule());
            kernel.Settings.AllowNullInjection = true;
            return kernel;
        }

    }
}
