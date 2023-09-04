public class Cat : Animal {
    public int Lives { get; set; }

    public Cat(string name, int lives) : base(name) { // N.B. base(name) means that before entering the constructor it jumps before in the derived class Animal and sets the name then goes to set the lives in this constructor
        Lives = lives;
    }

    public override void MakeSound() {
        Console.WriteLine("The cat meows");
    }
}