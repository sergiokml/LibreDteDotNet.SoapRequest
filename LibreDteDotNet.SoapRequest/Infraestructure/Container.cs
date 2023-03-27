using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Autofac;

namespace LibreDteDotNet.SoapRequest.Infraestructure
{
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
