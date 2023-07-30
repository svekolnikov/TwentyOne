using TwentyOne.Domain.ValueObjects;
using TwentyOne.Persistence;

namespace TwentyOne.Game;

public class CardDeckService
{
    private readonly Data _data;
    private readonly Random _random;
    public CardDeckService()
    {
        _random = new Random();
        _data = new Data();
        _data.Init();
    }
    
    public Stack<Card> Cards { get; set; }
    public void Init()
    {
        var cards = _data.Cards;
        Shuffle(cards);
    }

    public Card GetOne() => Cards.Pop();
    
    private void Shuffle(IList<Card> cards)
    {
        var n = cards.Count;
        while (n > 1)
        {
            n--;
            var k = _random.Next(n + 1);
            (cards[k], cards[n]) = (cards[n], cards[k]);
        }
    }
}