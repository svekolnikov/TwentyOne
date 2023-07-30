using TwentyOne.Game;

Console.WriteLine("Game starting...");

try
{
    var game = new Game();
    game.Run();
    
    Console.WriteLine("For Exit press any key");
}
catch (Exception e)
{
    Console.WriteLine($"Game crushed. {e.Message}");
}
