using TwentyOne.Domain.Enums;

namespace TwentyOne.Domain.ValueObjects;

public record Card(
    Suit Suit,
    CardValue Value)
{
    public override string ToString()
    {
        return $"{Suit.Emoji}{Value}";
    }
}