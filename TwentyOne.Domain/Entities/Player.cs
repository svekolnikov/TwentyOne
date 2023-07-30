using System.Text;
using TwentyOne.Domain.ValueObjects;

namespace TwentyOne.Domain.Entities;

public record Player(string Name)
{
    public HashSet<Card> Cards { get; private set; }
    public int Total { get; private set; }

    public void AddCard(Card card)
    {
        Cards.Add(card);
        Cards = Cards
            .OrderBy(x => x.Value)
            .ToHashSet();
        
        Total = CalculateTotal(Cards);
    }

    private int CalculateTotal(HashSet<Card> cards)
    {
        return cards.Select(x => (int)x.Value).Sum();
    }

    private string GetListOfCards(HashSet<Card> cards)
    {
        var sb = new StringBuilder();
        foreach (var card in cards)
        {
            sb.Append($"{card.Value} \n");
        }
        return sb.ToString();
    }

    public override string ToString()
    {
        return $"Player ${Name}, cards:\n" +
               $"{GetListOfCards(Cards)}";
    }
}