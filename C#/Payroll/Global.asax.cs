using System.Web.Http;

namespace Payroll
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            UnityConfiguration.RegisterUnity();
            GlobalConfiguration.Configure(PayrollWebAPIConfig.Register);
/*
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
*/
        }
    }
}
