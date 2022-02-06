using TextGenerator.Interfaces;

namespace TextGenerator;
public class RandomTextGenerator : ITextGenerator
{
    public string Get()
    {
        return "RandomText";
    }
}
