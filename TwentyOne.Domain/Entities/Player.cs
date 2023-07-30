using TwentyOne.Domain.ValueObjects;

namespace TwentyOne.Domain.Entities;

public record Player(string Name)
{
    public HashSet<Card> Cards { get; private set; } = new();
    public int TotalValues { get; private set; }

    public int GrabCard(Card card)
    {
        Cards.Add(card);
        Cards = Cards
            .OrderBy(x => x.Value)
            .ToHashSet();
        
        TotalValues = CalculateTotalValues(Cards);
        return TotalValues;
    }

    private int CalculateTotalValues(HashSet<Card> cards)
    {
        return cards.Select(x => (int)x.Value).Sum();
    }

    private string GetListOfCardNames(HashSet<Card> cards)
    {
        return string.Join(" ", cards);
    }

    public override string ToString()
    {
        return $"Player {Name}: " +
               $"{GetListOfCardNames(Cards)}\n" +
               $"Total: {TotalValues}\n";
    }
}