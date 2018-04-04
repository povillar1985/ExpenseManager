using Autofac;
using Autofac.Integration.WebApi;
using ExpenseManager.Data.Services;
using ExpenseManager.Repo;
using ExpenseManager.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace ExpenseManager.WebApi.App_Start
{
    public class AutofacWebApiConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());


            builder.RegisterType<InvoiceService>().As<IInvoiceService>().InstancePerDependency();
            builder.RegisterType<ExpenseDbContext>().AsSelf().InstancePerDependency();

            Container = builder.Build();

            return Container;
        }

    }



    public class Bootstrapper
    {
        public static void Run()
        {
            AutofacWebApiConfig.Initialize(GlobalConfiguration.Configuration);
        }

    }
}