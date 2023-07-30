using TwentyOne.Domain.ValueObjects;
using TwentyOne.Persistence;

namespace TwentyOne.Game;

public class CardDeckService
{
    private readonly Data _data;
    private readonly Random _random;
    
    public LinkedList<Card> Cards { get; private set; }
    public Card? CardOnTheCardDeck { get; private set; }
    
    public CardDeckService()
    {
        _random = new Random();
        _data = new Data();
        _data.Init();
    }
    
    public void Init()
    {
        var cards = _data.Cards;
        Shuffle(cards);
        Cards = new LinkedList<Card>(cards);
    }

    public Card GetTopOne()
    {
        var card = Cards.Last!.Value;
        Cards.RemoveLast();
        return card;
    }
    public Card GetBottomOne()
    {
        var card = Cards.First!.Value;
        Cards.RemoveFirst();
        return card;
    }

    public void LayCardOnTheCardDeck(Card card)
    {
        CardOnTheCardDeck = card;
        Console.WriteLine($"Card on the card deck: {CardOnTheCardDeck}\n");
    }
    
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