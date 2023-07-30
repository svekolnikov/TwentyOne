using System.Text;
using TwentyOne.Domain.ValueObjects;

namespace TwentyOne.Domain.Entities;

public record Player(string Name)
{
    public HashSet<Card> Cards { get; private set; } = new();
    public int TotalValues { get; private set; }

    public void GrabCard(Card card)
    {
        Cards.Add(card);
        Cards = Cards
            .OrderBy(x => x.Value)
            .ToHashSet();
        
        TotalValues = CalculateTotalValues(Cards);
    }

    private int CalculateTotalValues(HashSet<Card> cards)
    {
        return cards.Select(x => (int)x.Value).Sum();
    }

    private string GetListOfCardNames(HashSet<Card> cards)
    {
        var sb = new StringBuilder();
        foreach (var card in cards)
        {
            sb.Append($"{card.Suit.Name} {card.Value} {(int)card.Value}\n");
        }
        return sb.ToString();
    }

    public override string ToString()
    {
        return $"Player ${Name}, cards:\n" +
               $"{GetListOfCardNames(Cards)}";
    }
}