using System.Text;
using TwentyOne.Domain.Entities;

namespace TwentyOne.Game;

public class Game
{
    private readonly PlayersService _playersService;
    public Game()
    {
        _playersService = new PlayersService();
    }

    public void Run()
    {
        _playersService.InitPlayers();
        Console.WriteLine($"Game started with players:\n{_playersService.PrintPlayers()}");
    }

    

}