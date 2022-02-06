using ConsoleApp.Interfaces;
using TextGenerator.Interfaces;

namespace ConsoleApp.Impl;

public class ConsoleTextWriter : ITextWriter
{
    private readonly ITextGenerator _textGenerator;

    public ConsoleTextWriter(ITextGenerator textGenerator)
    {
        _textGenerator = textGenerator;
    }

    public void Write()
    {
        var text = _textGenerator.Get();
        Console.WriteLine(text);
    }
}