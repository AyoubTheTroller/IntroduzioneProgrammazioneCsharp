using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What do u wanna see?");
        Console.WriteLine("Digit 1 for variables and data types");
        string choice = Console.ReadLine();
        switch(choice){
            case "1":
                variablesAndDataTypes();
                break;
            case "2":
                operators();
                break;
        }
    }

    static void variablesAndDataTypes(){
        string variablesInfos = "byte: 8 bits, 0 to 255\n"
                                + "sbyte: 8 bits, -128 to 127\n"
                                + "short: 16 bits, -32,768 to 32,767\n"
                                + "ushort: 16 bits, 0 to 65,535\n"
                                + "int: 32 bits, -2,147,483,648 to 2,147,483,647\n"
                                + "uint: 32 bits, 0 to 4,294,967,295\n"
                                + "long: 64 bits, -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807\n"
                                + "ulong: 64 bits, 0 to 18,446,744,073,709,551,615\n"
                                + "float: 32 bits, approximately ±1.5 x 10^-45 to ±3.4 x 10^38\n"
                                + "double: 64 bits, approximately ±5.0 x 10^-324 to ±1.7 x 10^308\n"
                                + "decimal: 128 bits, approximately ±1.0 x 10^-28 to ±7.9 x 10^28\n"
                                + "bool: 8 bits, true or false\n"
                                + "char: 16 bits, represents a single Unicode character\n"
                                + "string: represents a sequence of Unicode characters";
        Console.WriteLine();
        Console.WriteLine("Below are listed all variables size and memory informations :\n" + variablesInfos);

        byte a = 255;
        int b = 1000;
        long c = 10000000000L;
        float d = 1.234F;
        double e = 1.234;
        decimal f = 1.234M;
        bool g = true;
        char h = 'A';
        string i = "Hello";

    }

    static void operators(){
        string availableOperators = "Arithmetic operators: +, -, *, /, %\n"
                                    + "Comparison operators: ==, !=, <, >, <=, >=\n"
                                    + "Logical operators: &&, ||, !\n";
        Console.WriteLine();
        Console.WriteLine("Below are listed all operator informations :\n" + availableOperators);      
    }

    static void typeConversions(){
        //// Implicit conversion - Automatic - done by compiler ////
        int j = 10;
        double k = j;
        ////////////////////////////////////////////////////////////
        //// Explicit conversion - Manual ////
        double l = 10.5;
        int m = (int) l; // Casting (type)
        string str = "42"; 
        int i;
        i = Convert.ToInt32(str); // Using Convert
        i = int.Parse(str); // Using Parse
        if (int.TryParse(str, out i)) // Using TryParse
        {
            Console.WriteLine($"Successfully converted to {i}");
        }
        else
        {
            Console.WriteLine("Conversion failed");
        }
        ////////////////////////////////////////////////////////
    }



}

