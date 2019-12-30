using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Vehicle.MVC;

namespace Vehicle.Web
{
    public class MvcApplication : HttpApplication
    {
        protected static void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
