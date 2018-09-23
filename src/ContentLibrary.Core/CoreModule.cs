using Autofac;
using System.Linq;
using System.Reflection;

namespace ContentLibrary.Core
{
    public class CoreModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var asm = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(asm)
                   .Where(t => t.Name.EndsWith("Service"))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();
        }
    }
}
