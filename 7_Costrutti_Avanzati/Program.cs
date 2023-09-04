public class User{
    public string? Role { get; set; }
}

class Program{
    static void Main(string[] args){

        // PATTERN MATCHING ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        User user = new User { Role = "Admin" };

        string accessLevel = user.Role switch // IN THIS CASE IS VALUE MATCHING
        {
            "Admin" => "Full Access",
            "Editor" => "Write Access",
            "Viewer" => "Read-Only",
            _ => "No Access"
        };

        Console.WriteLine($"User has {accessLevel}");

        // MORE COMPLEX SCENARIO 

        var premium = new PremiumCustomer { Name = "Alice", RewardPoints = 1200 };
        var regular = new RegularCustomer { Name = "Bob", YearsAsCustomer = 6 };
        var newbie = new NewCustomer { Name = "Charlie" };

        Console.WriteLine($"Discount for {premium.Name}: {CalculateDiscount(premium)}");
        Console.WriteLine($"Discount for {regular.Name}: {CalculateDiscount(regular)}");
        Console.WriteLine($"Discount for {newbie.Name}: {CalculateDiscount(newbie)}");

        // LAMBDA EXPRESSIONS ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        List<Product> products = new List<Product>{
            new Product { Name = "Apple", Price = 1.2 },
            new Product { Name = "Banana", Price = 0.8 }
        };

        var sortedProducts = products.OrderBy(p => p.Price); // Lamba used here to pass the collection of Product to the LINQ OrderBy

        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }

        // A REAL LIFE SCENARIO 

        List<Product> cartItems = new List<Product>
        {
            new Product { Name = "Laptop", Price = 999.99 },
            new Product { Name = "Mouse", Price = 19.99 },
            new Product { Name = "Keyboard", Price = 49.99 }
        };

        var sortedCartItems = cartItems.OrderBy(p => p.Price); // Lamba used here to pass the collection of Product to the LINQ OrderBy

        Console.WriteLine("Your cart items, sorted by price:");
        foreach (var item in sortedCartItems)
        {
            Console.WriteLine($"{item.Name} - ${item.Price}");
        }

        // ANONYMOUS TYPES //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        List<Employee> employees = new List<Employee>
        {
            new Employee { FirstName = "John", LastName = "Doe", Salary = 50000 },
            new Employee { FirstName = "Jane", LastName = "Doe", Salary = 60000 }
        };

        var summaries = employees.Select(e => new { e.FirstName, e.LastName }); // Here is created the anonymous type with only firstName and LastName in order to keep the salary private

        foreach (var summary in summaries)
        {
            Console.WriteLine($"{summary.FirstName} {summary.LastName}");
        }

    }

    public static decimal CalculateDiscount(Customer customer){
        return customer switch // HERE THE PATTERN MATCHIN IS DONE ON MULTIPLE VALUES
        {
            PremiumCustomer p when p.RewardPoints > 1000 => 0.1M,
            RegularCustomer r when r.YearsAsCustomer > 5 => 0.05M,
            RegularCustomer r when r.YearsAsCustomer <= 5 => 0.02M,
            NewCustomer => 0.01M,
            null => throw new ArgumentNullException(nameof(customer)),
            _ => 0.0M
        };
    }

    // LAMBDA EXPRESSIONS

}