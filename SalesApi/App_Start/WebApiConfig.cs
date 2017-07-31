using System.Web.Http;
using SalesApi.Models;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using SimpleInjector.Integration.WebApi;
using SalesApi.Services;

namespace SalesApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {   
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
           
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            container.Register<ISalesOrderContext, SalesOrderContext>(Lifestyle.Scoped);
            container.Register<ISalesOrderService, SalesOrderService>(Lifestyle.Scoped);
            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);            
        }
    }
}
