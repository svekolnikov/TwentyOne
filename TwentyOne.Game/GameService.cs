using System.Text;
using TwentyOne.Domain.Entities;

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
        _playersService.Init();
        _cardDeckService.Init();
        Console.WriteLine($"GameService started with players:\n{_playersService.PrintPlayers()}");
    }

    

}