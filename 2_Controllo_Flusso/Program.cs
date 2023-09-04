using System;

class Program
{
    static void Main(string[] args)
    {   
        /// if statement //////////////////////////////////////////////////////////
        Console.WriteLine("\nif statement");
        int x = 10;
        if (x > 5)
        {
            Console.WriteLine("x is greater than 5");
        }


        /// if - else statement ///////////////////////////////////////////////////
        Console.WriteLine("\nif - else statment");
        int y = 3;
        if (y > 5)
        {
            Console.WriteLine("y is greater than 5");
        }
        else
        {
            Console.WriteLine("y is less than or equal to 5");
        }


        /// if - else & else - if statements ///////////////////////////////////////
        Console.WriteLine("\nif - else & else - if statements");
        int z = 5;
        if (z > 5)
        {
            Console.WriteLine("z is greater than 5");
        }
        else if (z < 5)
        {
            Console.WriteLine("z is less than 5");
        }
        else
        {
            Console.WriteLine("z is equal to 5");
        }
        /// LOOPS ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        

        /// for //////////////////////////////////////// 
        Console.WriteLine("\nfor");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(i+" ");  // Output: 0 1 2 3 4 
        }
        Console.WriteLine();


        /// foreach ////////////////////////////////////////////////////////////////
        Console.WriteLine("\nforeach");
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)
        {
            Console.Write(number+" ");  // Output: 1 2 3 4 5
        }
        Console.WriteLine();


        /// while //////////////////////////////////////////////////////////////////
        Console.WriteLine("\nwhile");
        int j = 0;
        while (j < 5)
        {
            Console.Write(j+" ");  // Output: 0 1 2 3 4
            j++;
        }
        Console.WriteLine();


        /// do while ///////////////////////////////////////////////////////////////
        Console.WriteLine("\ndo while");
        int k = 0;
        do
        {
            Console.Write(k+" ");  // Output: 0 1 2 3 4
            k++;
        } while (k < 5);
        Console.WriteLine();


        /// switch /////////////////////////////////////////////////////////////////
        Console.WriteLine("switch");
        int option = 2;
        switch (option)
        {
            case 1:
                Console.WriteLine("You selected option 1");
                break;
            case 2:
                Console.WriteLine("You selected option 2");
                break;
            case 3:
                Console.WriteLine("You selected option 3");
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        } // Output: You selected option 2
        Console.WriteLine();


        /// Ternary operator ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// The ternary conditional operator ? : is a shorthand way of using an if-else statement. It takes three operands: a condition, a result for true, and a result for false.
        Console.WriteLine("ternary operator");
        int p = 10;
        string result = (p > 5) ? "greater than 5" : "less than or equal to 5";
        Console.WriteLine(result+"\n");  // Output: greater than 5


        /// Null Coalescing Operator ??
        /// The null coalescing operator ?? is used to replace a nullable value with a default value if the nullable value is null.
        Console.WriteLine("Null Coalescing Operator");
        int? w = null; // the operator ? in front of the type indicates that the variable is nullable 
        int q = w ?? 0;
        Console.WriteLine(q+" ");  // Output: 0
        if (w.HasValue) // You can check if a nullable type has a value using HasValue
        {
            int value = w.Value;
            Console.WriteLine($"w has a value: {value}");
        }
        else
        {
            Console.WriteLine("w is null");
        }
        Console.WriteLine();


        /// Null conditional Operator ?. ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// The null conditional operator ?. allows you to access members and elements only if the object is not null, returning null otherwise.
        string name = null;
        int? length = name?.Length; // length is null, no exception thrown
        /// You can also chain null-conditional operators, below commented
        /// var item = someObject?.SomeProperty?.SomeMethod(); // In this example, if someObject is null, then someObject?.SomeProperty?.SomeMethod() will immediately return null without evaluating SomeProperty or SomeMethod().
        /// You can also use null-conditional operators with indexers, below commented
        /// int? firstElement = someArray?[0]; -> Will be null if someArray is null
        /// You can use it to conditionally invoke methods, below commented
        /// int? result = someList?.FirstOrDefault(); -> Will return null if someList is null
        /// You can combine the null-conditional operator with the null coalescing operator ?? for more concise code, below 
        length = name?.Length ?? 0;  // Returns 0 if name is null


        /// Break and Continue
        /// break: Exits the nearest enclosing loop or switch statement. continue: Skips the remaining code in the current iteration and jumps to the next iteration of the loop.
        Console.WriteLine("Break and Continue");
        for (int i = 0; i < 5; i++)
        {
            if (i == 2)
            {
                continue;
            }
            if (i == 4)
            {
                break;
            }
            Console.Write(i+" ");  // Output: 0 1 3
        }
        Console.WriteLine("\n");


        /// Goto Statement //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Although generally not recommended because it can make code less readable and maintainable, C# does support the goto statement to jump to a labeled statement.
        Console.WriteLine("Goto Statement");
        int ii = 0;
        startOO: // here the labeled statement
        if (ii < 3)
        {
            Console.Write(ii+" ");  // Output: 0 1 2
            ii++;
            goto startOO;
        }
        Console.WriteLine("\n");


        /// Checked and Unchecked /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// These keywords are used to control the overflow-checking context for integral-type arithmetic operations and conversions. checked: Generates an overflow exception. unchecked: Ignores overflow.
        Console.WriteLine("Checked and Unchecked");
        int max = int.MaxValue;
        try
        {
            checked
            {
                max = max + 1;
            }
        }
        catch (System.OverflowException e)
        {
            Console.WriteLine(e.Message);  // Output: Arithmetic operation resulted in an overflow.
        }
        Console.WriteLine("\n");
        
    }
}
