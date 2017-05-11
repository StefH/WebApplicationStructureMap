using System.Web.Http;
using ClassLibrary1;
using StructureMap;
using WebApi.StructureMap;

namespace WebApplicationStructureMap
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            GlobalConfiguration.Configuration.UseStructureMap(x =>
            {
                x.Scan(cfg =>
                {
                    cfg.Description = "WebApiApplication Main Scanner";
                    //cfg.TheCallingAssembly();
                    cfg.AssembliesFromApplicationBaseDirectory(a => a.FullName.StartsWith("ClassLi") || a.FullName.StartsWith("WebApp"));
                    cfg.LookForRegistries();
                });
            });

            var xxd = GlobalConfiguration.Configuration.DependencyResolver.GetService<IBar>();

            var ic = GlobalConfiguration.Configuration.DependencyResolver.GetService<IC>();

            int u= 0;
        }
    }
}