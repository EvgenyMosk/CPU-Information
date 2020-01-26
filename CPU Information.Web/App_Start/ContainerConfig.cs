using Autofac;
using Autofac.Integration.Mvc;
using CPU_Information.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CPU_Information.Web {
    public class ContainerConfig {
        internal static void RegisterContainer() {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<InMemoryCPUData>()
                   .As<ICPUData>()
                   .SingleInstance();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}