using System.Text;
using TwentyOne.Domain.Entities;

namespace TwentyOne.Game;

public class PlayersService
{
    private const int MaxPlayers = 4; 
    public HashSet<Player> Players { get; private set; } = new();
    
    public int PlayersCount() => Players.Count;
    public string PrintPlayers()
    {
        var sb = new StringBuilder();
        foreach (var player in Players)
        {
            sb.Append($"{player.Name} \n");
        }
        return sb.ToString();
    }
    public void InitPlayers()
    {
        Console.WriteLine("Enter players names: \n");
        while (Players.Count() < MaxPlayers)
        {
            var name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                continue;
            }
            
            AddPlayer(name);
        }
    }
    
    
    private void AddPlayer(string name)
    {
        var player = new Player(name);
        Players.Add(player);
    }
}