using TwentyOne.Domain.Enums;

namespace TwentyOne.Domain.ValueObjects;

public record Suit(string Emoji, Suits Name)
{
    public override string ToString()
    {
        return $"{Emoji} {Name}";
    }
}