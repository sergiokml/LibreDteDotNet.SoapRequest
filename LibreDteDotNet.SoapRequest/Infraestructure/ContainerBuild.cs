using Autofac;
using Autofac.Extensions.DependencyInjection;

using LibreDteDotNet.RestRequest.Interfaces;
using LibreDteDotNet.SoapRequest.Infraestructure;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LibreDteDotNet.RestRequest.Infraestructure
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
}
