Unhandled exception. Autofac.Core.Registration.ComponentNotRegisteredException: The requested service 'ConsoleApp.Interfaces.ITextWriter' has not been registered. To avoid this exception, either register a component to provide the service, check for service registration using IsRegistered(), or use the ResolveOptional() method to resolve an optional dependency.
   at Autofac.ResolutionExtensions.ResolveService(IComponentContext context, Service service, IEnumerable`1 parameters)
   at Autofac.ResolutionExtensions.Resolve(IComponentContext context, Type serviceType, IEnumerable`1 parameters)
   at Autofac.ResolutionExtensions.Resolve[TService](IComponentContext context, IEnumerable`1 parameters)
   at Autofac.ResolutionExtensions.Resolve[TService](IComponentContext context)
   at Program.<Main>$(String[] args) in /Users/gerrit/Code/IocTests/src/ConsoleApp/Program.cs:line 7