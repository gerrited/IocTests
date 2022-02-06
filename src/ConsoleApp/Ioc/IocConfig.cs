using Autofac;
using ConsoleApp.Impl;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Ioc;

public class IocConfig
{
    public IContainer Create()
    {
        var builder = new ContainerBuilder();
        
        builder.RegisterType<ConsoleTextWriter>().As<ITextWriter>();
        builder.RegisterModule<TextGeneratorModule>();

        return builder.Build();
    }
}