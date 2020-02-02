using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using CPU_Information.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace CPU_Information.Web {
    public class ContainerConfig {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration) {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<InMemoryCPUData>()
                   .As<ICPUData>()
                   .SingleInstance();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}