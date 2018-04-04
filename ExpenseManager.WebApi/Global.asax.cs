using ExpenseManager.WebApi.App_Start;
using System.Web.Http;

namespace ExpenseManager.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Registering IoC
            Bootstrapper.Run();

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
