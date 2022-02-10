using ConsoleApp.Ioc;
using ConsoleApp.Impl;
using ConsoleApp.Interfaces;
using TextGenerator.Interfaces;

using Autofac;
using Autofac.Core.Registration;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace ConsoleApp.UnitTests;

public class IocConfigTests
{
    [Test]
    public void Resolve_ITextWriter_NotThrowComponentNotRegisteredException()
    {
        var sut = CreateContainerWithTestDoubles();

        var act = () => sut.Resolve<ITextWriter>();

        act.Should().NotThrow<ComponentNotRegisteredException>();
    }

    [Test]
    public void Resolve_ITextWriter_ReturnConsoleTextWriter()
    {
        var sut = CreateContainerWithTestDoubles();

        var result = sut.Resolve<ITextWriter>();

        result.Should().BeOfType<ConsoleTextWriter>();
    }

    [Test]
    public void IsRegistered_ITextGenerator()
    {
        var sut = CreateContainer();

        var result = sut.IsRegistered<ITextGenerator>();

        result.Should().BeTrue();
    }

    private ContainerBuilder CreateContainerBuilder()
    {
        var iocConfig = new IocConfig();
        return iocConfig.GetBuilder();
    }

    private IContainer CreateContainer()
    {
        var builder = CreateContainerBuilder();
        return builder.Build();
    }

    private IContainer CreateContainerWithTestDoubles()
    {
        var builder = CreateContainerBuilder();
        builder.Register(c => Mock.Of<ITextGenerator>()).As<ITextGenerator>();
        return builder.Build();
    }
}