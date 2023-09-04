public abstract class Customer
{
    public string? Name { get; set; }
}

public class RegularCustomer : Customer
{
    public int YearsAsCustomer { get; set; }
}

public class PremiumCustomer : Customer
{
    public int RewardPoints { get; set; }
}

public class NewCustomer : Customer
{
}
