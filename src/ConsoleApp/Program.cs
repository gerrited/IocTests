using Autofac;
using ConsoleApp.Ioc;
using ConsoleApp.Interfaces;

var container = new IocConfig().Create();

var writer = container.Resolve<ITextWriter>();

writer.Write();
