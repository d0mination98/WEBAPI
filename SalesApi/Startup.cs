using Microsoft.Owin;
using Owin;
using SalesApi.Models;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;
using SalesApi.Services;

[assembly: OwinStartup(typeof(SalesApi.Startup))]

namespace SalesApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {          
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Register<ISalesOrderContext, SalesOrderContext>(Lifestyle.Scoped);
            container.Register<ISalesOrderService, SalesOrderService>(Lifestyle.Transient);
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
            app.UseWebApi(GlobalConfiguration.Configuration);
        }
    }
}
