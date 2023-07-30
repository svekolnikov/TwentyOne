using TwentyOne.Game;

Console.WriteLine("Application starting...");
try
{
    var game = new GameService();
    game.Run();
    Console.WriteLine("For Exit press any key");
    Console.ReadKey();
}
catch (Exception e)
{
    Console.WriteLine($"Application crushed. {e.Message}");
}
