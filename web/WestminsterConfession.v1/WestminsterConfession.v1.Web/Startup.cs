using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Ninject;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using WestminsterConfession.v1.Web;
using WestminsterConfession.v1.Web.NinjectModules;

[assembly: OwinStartup("ProductionConfiguration", typeof(Startup))]
namespace WestminsterConfession.v1.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            var httpConfiguration = new HttpConfiguration();
            ConfigureWebApi(httpConfiguration);
            app.UseWebApi(httpConfiguration);


            var kernel = CreateKernel();
            app.UseNinjectMiddleware(() => kernel).UseNinjectWebApi(httpConfiguration);
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel(new BussinesModule());
            kernel.Settings.AllowNullInjection = true;

            return kernel;
        }

        private static void ConfigureWebApi(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        } // ConfigureWebApi
    }
}
