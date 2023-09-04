public class Dog : Animal {
    public string Breed { get; set; }

    public Dog(string name, string breed) : base(name) { // N.B. base(name) means that before entering the constructor it jumps before in the derived class and sets the name then goes to set the breed in this constructor
        Breed = breed;
    }

    public override void MakeSound() {
        Console.WriteLine("The dog barks");
    }
}
