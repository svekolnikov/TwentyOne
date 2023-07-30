using TwentyOne.Game;

Console.WriteLine("Application starting...");
try
{
    var game = new Game();
    game.Run();
    Console.WriteLine("For Exit press any key");
}
catch (Exception e)
{
    Console.WriteLine($"Application crushed. {e.Message}");
}
