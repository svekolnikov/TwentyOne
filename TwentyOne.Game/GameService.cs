using System.Threading.Channels;

namespace TwentyOne.Game;

public class GameService
{
    private readonly PlayersService _playersService;
    private readonly CardDeckService _cardDeckService;
    public GameService()
    {
        _playersService = new PlayersService();
        _cardDeckService = new CardDeckService();
    }

    public void Run()
    {
        _cardDeckService.Init();
        _playersService.Init();
        DistributionCardsToPlayers();
        Playing();
    }

    private void DistributionCardsToPlayers()
    {
        Console.WriteLine("######################## Distributing ########################");
        for (var i = 0; i < _playersService.PlayersCount(); i++)
        {
            _playersService.GiveCardToCurrentPlayer(_cardDeckService.GetTopOne());
            _playersService.ShiftQueue();
        }

        _playersService.PrintInfo();

        Console.WriteLine("Place the bottom card on top of the deck, face up");
        var bottomCard = _cardDeckService.GetBottomOne();
        _cardDeckService.LayCardOnTheCardDeck(bottomCard);
    }

    private void Playing()
    {
        Console.WriteLine("######################## Playing #############################");
        while (true)
        {
            _playersService.PrintCurrentPlayerName();
            var isPlayerGoingTookCard = SuggestTakeOrSkip();
            if (isPlayerGoingTookCard)
            {
                _playersService.GiveCardToCurrentPlayer(_cardDeckService.GetBottomOne());
            }
            else
            {
                var name = _playersService.PlayerName();
                Console.WriteLine($"Player {name} skipped\n");
            }
            _playersService.PrintInfo(); 
            _playersService.ShiftQueue();
        }
    }

    private bool SuggestTakeOrSkip()
    {
        ConsoleKeyInfo keyInfo;
        do
        {
            Console.Write("Take card y/n?: ");
            keyInfo = Console.ReadKey();
            Console.WriteLine("\n");
        } while (keyInfo.KeyChar is not ('Y' or 'y' or 'N' or 'n'));

        return keyInfo.KeyChar switch
        {
            'Y' or 'y' => true,
            'N' or 'n' => false,
            _ => false
        };
    }
}