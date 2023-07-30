using TwentyOne.Domain.ValueObjects;
using TwentyOne.Persistence;

namespace TwentyOne.Game;

public class CardDeckService
{
    private readonly Data _data;
    public CardDeckService()
    {
        _data = new Data();
        _data.Init();
    }
    
    public Stack<Card> Cards { get; set; }
    public void Init()
    {
        var cards = _data.Cards;
        Mix(cards);
    }

    public Card GetOne() => Cards.Pop();
    
    private void Mix(HashSet<Card> cards)
    {
        
    }
}