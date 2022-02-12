using Autofac;
using TextGenerator;
using TextGenerator.Interfaces;

public class TextGeneratorModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<RandomTextGenerator>().As<ITextGenerator>();
    }
}
