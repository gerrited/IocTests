using ConsoleApp.Ioc;
using ConsoleApp.Impl;
using ConsoleApp.Interfaces;

using Autofac;
using Autofac.Core.Registration;
using FluentAssertions;
using NUnit.Framework;

namespace ConsoleApp.UnitTests;

public class IocConfigTests
{
    [Test]
    public void Resolve_ITextWriter_NotThrowComponentNotRegisteredException()
    {
        var sut = CreateContainer();

        var act = () => sut.Resolve<ITextWriter>();

        act.Should().NotThrow<ComponentNotRegisteredException>();
    }
    
    [Test]
    public void Resolve_ITextWriter_ReturnConsoleTextWriter()
    {
        var sut = CreateContainer();

        var result = sut.Resolve<ITextWriter>();

        result.Should().BeOfType<ConsoleTextWriter>();
    }

    [Test]
    public void IsRegistered_TextWriter()
    {
        var sut = CreateContainer();

        var result = sut.IsRegistered<ITextWriter>();

        result.Should().BeTrue();
    }

    private IContainer CreateContainer()
    {
        var iocConfig = new IocConfig();
        return iocConfig.Create();
    }
}