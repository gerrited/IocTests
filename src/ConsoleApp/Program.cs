using Autofac;
using ConsoleApp.Ioc;
using ConsoleApp.Interfaces;

var iocConfig = new IocConfig();
var builder = iocConfig.GetBuilder();
var container = builder.Build();

var writer = container.Resolve<ITextWriter>();

writer.Write();
