using System;

class Program
{
    static void Main()
    {
        /*
            try: The code inside the try block is the code you anticipate might throw an exception.
            catch: If an exception occurs, the code inside the catch block runs. You can catch specific exceptions or catch all exceptions.
            finally: The finally block contains code that will execute no matter what—whether an exception is thrown or not.
        */
        try
        {
            int divisor = 0;
            int result = 10 / divisor; // This will throw a DivideByZeroException
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Caught exception: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("This code runs regardless of an exception");
        }

        // Custom Exceptions //////////////////////////////////////////////////////////////////////////////////////////
        try
        {
            ValidateAge(200); // This will throw the custom exception
        }
        catch (AgeOutOfRangeException ex)
        {
            Console.WriteLine($"Caught exception: {ex.Message}");
            Console.WriteLine($"Invalid age: {ex.InvalidAge}");
        }

        // A More complex Scenario for exceptions ////////////////////////////
        AuthService authService = new AuthService();
        AuthenticationHandler authHandler = new AuthenticationHandler();
        authHandler.Handle(authService, "john", "wrongpassword");
    }

    static void ValidateAge(int age)
    {
        if (age < 0 || age > 150)
        {
            throw new AgeOutOfRangeException("Age should be between 0 and 150.", age);
        }
    }
}

