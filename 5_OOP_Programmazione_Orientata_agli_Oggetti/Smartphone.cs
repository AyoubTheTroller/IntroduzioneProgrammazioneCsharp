public class Smartphone : IPlayable{
    public void PlayGame(string gameName)
    {
        Console.WriteLine($"Playing {gameName} on the smartphone.");
    }
}