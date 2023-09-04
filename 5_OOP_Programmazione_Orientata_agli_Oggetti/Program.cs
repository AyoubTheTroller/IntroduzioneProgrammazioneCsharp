class Program{
    public static void Main(String[] args) {
        // INITIALIZATION ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Car newCar = new Car("Honda","Civic",1994);

        // INHERITANCE FROM VEHICLE CLASS ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        newCar.Brand = "New"; 

        // POLYMORPHISM ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Animal myAnimal = new Animal("George");
        myAnimal.MakeSound();  // Output: "The animal makes a sound"

        Dog myDog = new Dog("Fido", "Labrador");
        myDog.MakeSound();  // Output: "The dog barks"

        Cat myCat = new Cat("Whiskers", 9);
        myCat.MakeSound();  // Output: "The cat meows"

        List<Animal> animals = new List<Animal> {
            new Animal("George"),
            new Dog("Fido", "Labrador"),
            new Cat("Whiskers", 9)
        };

        foreach (Animal animal in animals) {
            animal.MakeSound(); // Although the type of the animal variable is Animal, it's calling the MakeSound() method of the derived clases Dog and Cat, thanks to polymorphism.
        }

        // INTERFACES AND ABSTRACT CLASSES ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        IPlayable myPhone = new Smartphone();
        myPhone.PlayGame("Candy Crush");  // Output: "Playing Candy Crush on the smartphone."

        Computer myComputer = new Desktop();
        myComputer.Start();  // Output: "Starting the desktop..."

        // Combining Interface and Abstract Class 
        Laptop myLaptop = new Laptop();
        myLaptop.Start();  // Output: "Starting the laptop..."
        myLaptop.PlayGame("Overwatch");  // Output: "Playing Overwatch on the laptop."

        // COMPOSITION ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Book book1 = new Book { Title = "1984", Author = "George Orwell" };
        Book book2 = new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee" };

        Library library = new Library();
        library.AddBook(book1);
        library.AddBook(book2);

        library.ListBooks();

        // ENCAPSULATION ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Create a new BankAccount with an initial balance of $1000
        BankAccount myAccount = new BankAccount(1000.0);

        // Display initial balance
        Console.WriteLine("Initial balance: $" + myAccount.GetBalance()); // Output: "Initial balance: $1000"

        // Deposit $200 into the account
        myAccount.Deposit(200);
        Console.WriteLine("Balance after depositing $200: $" + myAccount.GetBalance()); // Output: "Balance after depositing $200: $1200"

        // Withdraw $150 from the account
        myAccount.Withdraw(150);
        Console.WriteLine("Balance after withdrawing $150: $" + myAccount.GetBalance()); // Output: "Balance after withdrawing $150: $1050"

        // Trying to withdraw more money than the balance should throw an exception
        try
        {
            myAccount.Withdraw(2000); // This will throw an InvalidOperationException
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);  // Output: "Not enough balance."
        }

        // Trying to deposit a negative amount should throw an exception
        try
        {
            myAccount.Deposit(-50);  // This will throw an ArgumentException
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);  // Output: "Deposit amount must be positive."
        }
        
        // Display the final balance
        Console.WriteLine("Final balance: $" + myAccount.GetBalance()); // Output: "Final balance: $1050"


        // Combining both Composition and Inheritance/polym /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Zoo myZoo = new Zoo();
        myZoo.AddAnimal(new Dog("KRICK","labrador"));
        myZoo.AddAnimal(new Cat("Silvestro", 57));
        myZoo.MakeSounds(); // Output: The dog barks, The cat meows

    }

   /* MAJOR DIFFERENCES BETWEEN COMPOSITION AND INHERITANCE/POLYM
        When to Prefer Composition:
            Loose Coupling: When you want to reduce the dependency between classes, composition is a better choice. Inherited classes are tightly coupled with their parent classes.

            Code Reusability: Composition allows you to reuse code without inheriting all the behaviors of the parent class, which may not always be desirable.

            Dynamic Behavior: When you need to change behavior at runtime, composition can be more flexible because you can easily replace components.

            Single Responsibility Principle: If a subclass inherits properties and behaviors from a parent class that it doesn't use, this could violate the Single Responsibility Principle. Composition allows an object to use just the features that it needs.

            Avoiding "Fragile Base Class Problem": Changing a base class in an inheritance hierarchy can break a lot of things. Composition doesn't have this problem.

            When you want "Has-A" relation: Composition represents a "Has-A" relationship. For example, a Library has books, rather than a Library is a Book.

        When to Prefer Inheritance and Polymorphism:
            Code Reusability and DRY: When the derived classes share a significant amount of code with the parent class, inheritance can help you adhere to the "Don't Repeat Yourself" principle.

            Type Substitutability: When you want to use the derived class object wherever you are using a base class object, inheritance is beneficial.

            Natural "Is-A" Relationship: When your subclass is a natural extension of the parent class, it makes sense to use inheritance. For example, a Cat is an Animal.

            Adding functionality: When you simply want to extend the functionality of an existing class, inheritance is the way to go.

            Code Organization: Inheritance can make the code more straightforward and easier to understand when there is a clear hierarchy and relationship between classes.

            Polymorphism: If you need to use polymorphism to call derived class methods through a base class reference, you'll need to use inheritance.
    
    */

}