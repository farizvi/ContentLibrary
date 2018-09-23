using Autofac;
using ContentLibrary.Data.Context;
using System.Reflection;

namespace ContentLibrary.Data
{
    public class DataModule : Autofac.Module
    {
        public string ConnectionString { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            var asm = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(asm)
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();

            builder.RegisterType<ContentContext>()
                   .AsSelf()                   
                   .InstancePerLifetimeScope();            
        }
    }
}
