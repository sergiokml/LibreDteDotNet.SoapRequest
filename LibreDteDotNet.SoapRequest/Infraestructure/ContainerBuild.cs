using System.Reflection;

using Autofac;
using Autofac.Extensions.DependencyInjection;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LibreDteDotNet.SoapRequest.Infraestructure
{
    public static class ContainerBuild
    {
        public static IHostBuilder SoapRequestBuild(this IHostBuilder host)
        {
            _ = host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            _ = host.ConfigureContainer<ContainerBuilder>(
                (config, builder) =>
                {
                    _ = builder.RegisterModule(new Container());
                }
            );
            _ = host.ConfigureServices(
                (config, services) =>
                {
                    _ = services.AddScoped<SoapRequest>();
                }
            );
            return host;
        }
    }

    internal class Container : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            Assembly? assembly = Assembly.GetExecutingAssembly();
            _ = builder
                .RegisterAssemblyTypes(assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces();
        }
    }
}
