using TwentyOne.Domain.Entities;
using TwentyOne.Domain.ValueObjects;

namespace TwentyOne.Game;

public class PlayersService
{
    private const int MaxPlayers = 4;
    private int _queue = 0;
    public List<Player> Players { get; private set; } = new();
    
    public int PlayersCount() => Players.Count;
    public string PlayerName() => Players[_queue].Name;
    
    public void Init()
    {
        Console.WriteLine("Enter players names:");
        while (Players.Count() < MaxPlayers)
        {
            var name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Not valid name, try again");
                continue;
            }
            AddPlayer(name);
        }
    }
    public void ShiftQueue()
    {
        _queue = _queue == PlayersCount() - 1
            ? 0
            : ++_queue;
    }
    public void PrintInfo()
    {
        Console.WriteLine("Cards on the player hands:");
        foreach (var player in Players)
        {
            Console.WriteLine(player);
        }
    }
    public void PrintCurrentPlayerName()
    {
        Console.WriteLine($"Current Player: {Players[_queue].Name}");
    }
    public Player GiveCardToCurrentPlayer(Card card)
    {
        var player = Players[_queue];
        var total = player.GrabCard(card);
        return player;
    }
    
    
    private void AddPlayer(string name)
    {
        var player = new Player(name);
        Players.Add(player);
    }
}