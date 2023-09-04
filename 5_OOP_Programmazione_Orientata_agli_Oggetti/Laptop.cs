public class Laptop : Computer, IPlayable{ // Combining Interface and Abstract Class
    public override void Start() // IMPLEMENTING THE ABSTRACT METHOD Start() OF THE ABSTRACT CLASS Computer
    {
        Console.WriteLine("Starting the laptop...");
    }

    public void PlayGame(string gameName) // IMPLEMENTING THE METHOD PlayGame() OF THE INTERFACE IPlayable 
    {
        Console.WriteLine($"Playing {gameName} on the laptop.");
    }
}

/*public class Laptop : Computer
{
    public override void Start()
    {
        Console.WriteLine("Starting the laptop...");
    }
}*/