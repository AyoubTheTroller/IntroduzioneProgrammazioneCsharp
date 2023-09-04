using System;

class Program{
    static void Main(string[] args){
        /* Array ///////////////////////////////////////////////////////////////////////////////////////////////
        Arrays are fixed-size collections of elements of the same data type.
        Useful Methods:
            Length: Get the total number of elements
            Sort(): Sort array in place
            GetValue(): Get value at a particular index
            SetValue(): Set value at a particular index
        */
        Console.WriteLine("Arrays");
        int[] numbers = { 3, 1, 4, 1, 5 };
        // Length
        Console.WriteLine(numbers.Length);  // Output: 5
        // Sort
        Array.Sort(numbers);
        foreach (var num in numbers)
        {
            Console.Write(num + " ");  // Output: 1 1 3 4 5
        }
        Console.WriteLine();
        // GetValue, SetValue
        Console.WriteLine(numbers.GetValue(0));  // Output: 1
        numbers.SetValue(9, 0);
        Console.WriteLine(numbers[0]);  // Output: 9
        Console.WriteLine();


        /* List //////////////////////////////////////////////////////////////////////////////////////////////////////
        Lists are dynamic-size collections, part of the System.Collections.Generic namespace.

        Useful Methods:
            Add(): Add an item
            Remove(): Remove an item
            Count: Get the number of elements
            Sort(): Sort the list in place
            IndexOf(): Get the index of an item
            Clear(): Remove all items
        */
        Console.WriteLine("Lists");
        List<int> numList = new List<int> { 3, 1, 4 };
        // Add
        numList.Add(1);
        // Remove
        numList.Remove(3);
        // Count
        Console.WriteLine(numList.Count);  // Output: 3
        // Sort
        numList.Sort();
        // IndexOf
        Console.WriteLine(numList.IndexOf(4));  // Output: 2
        // Clear
        numList.Clear();
        Console.WriteLine();


        /* Dictionary ////////////////////////////////////////////////////////////////////////////////////////////////////
        Dictionaries are collections of keys and values.

        Useful Methods:
            Add(): Add a key-value pair
            Remove(): Remove a key-value pair
            ContainsKey(): Check if a key exists
            TryGetValue(): Try to get a value by key
            Clear(): Remove all items
        */
        Console.WriteLine("Dictionaries");
        Dictionary<string, int> ages = new Dictionary<string, int> { { "Alice", 30 } };
        // Add
        ages.Add("Bob", 40);
        // Remove
        ages.Remove("Alice");
        // ContainsKey
        Console.WriteLine(ages.ContainsKey("Bob"));  // Output: True
        // TryGetValue
        if (ages.TryGetValue("Bob", out int age))
        {
            Console.WriteLine(age);  // Output: 40
        }
        // Clear
        ages.Clear();
        Console.WriteLine();


        /* HashSets ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        HashSets are collections that do not allow duplicate items.

        Useful Methods:
            Add(): Add an item (only if it does not exist)
            Remove(): Remove an item
            Contains(): Check if an item exists
            Clear(): Remove all items
        */
        Console.WriteLine("HashSets");
        HashSet<int> uniqueNums = new HashSet<int> { 1, 2, 3 };
        // Add
        uniqueNums.Add(4);
        uniqueNums.Add(3);  // Won't be added because it is a duplicated value otherwise and that is not allowed in HashSets
        // Remove
        uniqueNums.Remove(2);
        // Contains
        Console.WriteLine(uniqueNums.Contains(1));  // Output: True
        // Clear
        uniqueNums.Clear();
        Console.WriteLine();


        /* Queue /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Queues are First-In-First-Out (FIFO) collections.

        Useful Methods
            Enqueue(): Add an item to the end
            Dequeue(): Remove and return the item at the beginning
            Peek(): Look at the item at the beginning without removing it
            Clear(): Remove all items
        */
        Console.WriteLine("Queue");
        Queue<string> tasks = new Queue<string>();
        // Enqueue
        tasks.Enqueue("FirstTask");
        tasks.Enqueue("SecondTask");
        tasks.Enqueue("ThirdTask");
        // Dequeue
        Console.WriteLine(tasks.Dequeue());  // Output: FirstTask
        // Peek and Clear
        tasks.Peek();
        tasks.Clear();
        Console.WriteLine();


        /* Stack /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Stacks are Last-In-First-Out (LIFO) collections.

        Useful Methods
            Push(): Add an item to the top
            Pop(): Remove and return the item at the top
            Peek(): Look at the item at the top without removing it
            Clear(): Remove all items
        */
        Console.WriteLine("Stack");
        Stack<int> stack = new Stack<int>();
        // Push
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        // Pop
        Console.WriteLine(stack.Pop()+" ");  // Output: 1
        // Peek and Clear
        stack.Peek();
        stack.Clear();
        Console.WriteLine();    


        linq(); // method for linq operations and material

    }

    static void linq(){
        /* Utilizzo di LINQ (Language Integrated Query) //////////////////////////////
        LINQ allows you to query collections and other enumerable data types more easily and more readably and in a more declarative manner.
        
        constructs:
            Select: The Select method transforms each element of a sequence.
            Where: The Where method filters out elements that do not satisfy a condition.
            OrderBy: The OrderBy method sorts elements in ascending order.
            GroupBy: The GroupBy method groups elements that share a common attribute.
            Join: The Join method joins two sequences based on a key.
            Count: Returns the number of elements in a collection.
            Sum: Calculates the sum of numeric elements in a collection.
            Average: Calculates the average value of numeric elements in a collection.
            Min: Returns the minimum value from a collection.
            Max: Returns the maximum value from a collection.
            Aggregate: Performs a custom aggregation operation. The function is provided by the user and is applied to each element in the sequence.
            First and FirstOrDefault: Returns the first element of a collection. FirstOrDefault returns the default value for the type if the collection is empty.
            Last and LastOrDefault: Returns the last element of a collection. LastOrDefault returns the default value for the type if the collection is empty.
            Single and SingleOrDefault: Returns a single element from a collection. Throws an exception if there's more than one element. SingleOrDefault returns the default value for the type if the collection is empty.
            All: Returns true if all elements in the collection satisfy a given predicate.
            Any: Returns true if any elements in the collection satisfy a given predicate.
            Contains: Checks if the collection contains a specific element.
        */
        Console.WriteLine("LINQ (Language Integrated Query)\n");
        // Select ////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("Select");
        int[] numbers = { 1, 2, 3, 4, 5 };
        var squares = from num in numbers
                    select num * num; // num*num -> squares = { 1, 4, 9, 16, 25 }
        // DIFFERENT WAYS TO PRINT var squares
        // Using foreach - traditional way
        foreach (var square in squares)
        {
            Console.Write(square + " ");
        }
        Console.WriteLine();
        // Using string.Join
        Console.WriteLine(string.Join(" ", squares));
        // Using LINQ's Aggregate
        var result = squares.Aggregate("", (acc, val) => acc + val + " ");
        Console.WriteLine(result.Trim());
        // Using LINQ and Console.WriteLine
        squares.ToList().ForEach(Console.Write);
        Console.WriteLine();

        // Where ////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("Where");
        var evenNumbers = numbers.Where(n => n % 2 == 0); // evenNumbers = { 2, 4 }
        Console.WriteLine(string.Join(" ", evenNumbers));
        Console.WriteLine();


        // Order by ////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("Order by");
        var sortedNumbers = from num in numbers
                     orderby num descending
                     select num; // sortedNumbers = { 5, 4, 3, 2, 1 }        
        Console.WriteLine(string.Join(" ", sortedNumbers));
        Console.WriteLine();


        // Group by ////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("Group by");
        var numberGroups = from num in numbers
                   group num by num % 2; // Groups: { {1, 3, 5}, {2, 4} }
        foreach (var group in numberGroups){
            var groupList = string.Join(" ", group);
            Console.WriteLine($"Key: {group.Key} => {groupList}");
        }
        Console.WriteLine();


        // Join ////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("Join");
        var people = new[] { new { Name = "Alice" }, new { Name = "Bob" } };
        var ages = new Dictionary<string, int> { { "Alice", 30 }, { "Bob", 40 } };

        var joinQuery = from person in people
                        join age in ages on person.Name equals age.Key
                        select new { person.Name, Age = age.Value }; // joinQuery = { { "Alice", 30 }, { "Bob", 40 } }
        Console.WriteLine(string.Join(" ",joinQuery));
        Console.WriteLine();


        // int[] numbers = { 1, 2, 3, 4, 5 };
        // Count
        int count = numbers.Count(); // count = 5
        Console.WriteLine();

        // Sum
        int sum = numbers.Sum(); // sum = 15

        // Average
        double avg = numbers.Average(); // avg = 3.0

        // Min
        int minVal = numbers.Min(); // minVal = 1

        // Max
        int maxVal = numbers.Max(); // maxVal = 5

        // Aggregate
        int aggregate = numbers.Aggregate((acc, val) => acc * val); // aggregate = 1*2*3*4*5 = 120

        // First and FirstOrDefault
        int first = numbers.First(); // first = 1
        int firstOrDefault = new int[0].FirstOrDefault(); // firstOrDefault = 0 (default for int)

        // Last and LastOrDefault
        int last = numbers.Last(); // last = 5
        int lastOrDefault = new int[0].LastOrDefault(); // lastOrDefault = 0

        // Single and SingleOrDefault
        int single = new int[] { 3 }.Single(); // single = 3
        int singleOrDefault = new int[0].SingleOrDefault(); // singleOrDefault = 0

        // All
        bool allEven = numbers.All(n => n % 2 == 0); // allEven = false

        // Any
        bool anyEven = numbers.Any(n => n % 2 == 0); // anyEven = true

        // Contains
        bool containsThree = numbers.Contains(3); // containsThree = true


        int[] cioa = {1,2,3,4 };
        int count1 = cioa.Count();















    }
}
