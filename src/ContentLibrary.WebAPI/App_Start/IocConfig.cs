using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using ContentLibrary.Core;
using ContentLibrary.Data;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

namespace ContentLibrary.WebAPI
{
    public static class IocConfig
    {
        public static void RegisterDependencies()
        {
            // Standard setup
            var builder = new ContainerBuilder();
            RegisterMvc(builder);
           
            RegisterModules(builder);
            RegisterHttp(builder);
            RegisterWebApi(builder);

            // Load the container
            InitContainer(builder);
        }

        private static void RegisterMvc(ContainerBuilder builder)
        {
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
        }

        private static void RegisterWebApi(ContainerBuilder builder)
        {
            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);
        }

        private static void RegisterModules(ContainerBuilder builder)
        {
            builder.RegisterModule<CoreModule>();
            builder.RegisterModule<DataModule>();
        }

        private static void RegisterHttp(ContainerBuilder builder)
        {
            builder.RegisterModule<AutofacWebTypesModule>();
        }

        private static void InitContainer(ContainerBuilder builder)
        {
            // Set the MVC dependency resolver to use Autofac
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            // Hook container up for Web API
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}