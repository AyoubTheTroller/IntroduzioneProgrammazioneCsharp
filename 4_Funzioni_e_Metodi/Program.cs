using System.Drawing;

class Program{
    public static void Main(string[] args){
        Console.WriteLine(Square(5)); // calling static method

        Program prog = new Program();// For non static methods create object and call the function using it
        Console.WriteLine(prog.Divide(34.9,2)); 
        Console.WriteLine(prog.Divide(34.9,0));
        Console.WriteLine(prog.Multiply(3,7));
        Console.WriteLine(prog.Add(3)); // second parameter not set and still working because declared as optional in the function

        int[] numbers = {1, 2, 3, 4, 5};
        int min, max; 
        // calling using out parameters
        prog.GetMinMax(numbers, out min, out max);  // min will be 1, max will be 5
        Console.WriteLine("min: " + min + " max:" + max);

        // calling using tuples
        var (minn, maxx) = prog.GetMinMax(new int[] {1, 2, 3, 4, 5}); // assigned to var min and var max separatly
        Console.WriteLine($"Min: {minn}, Max: {maxx}");  // Output: "Min: 1, Max: 5"

        (int Min, int Max) result = prog.GetMinMax(new int[] {1, 2, 3, 4, 5}); // assigned to the tuple result in order to be accessed/deconstructed later
        Console.WriteLine($"Min: {result.Min}, Max: {result.Max}");  // Output: "Min: 1, Max: 5"

    }

    public static int Square(int num) {
        return num * num;   
    }

    public double Divide(double a, double b) {
        if(b == 0) {
            return double.NaN;  // Return 'Not a Number' if division by zero
        }
        return a / b;
    }

    public int Multiply(int a, int b) {
        return a * b;
    }

    public int Add(int a, int b = 0) { // optional parameter b -> was assigned to it the default value 0
        return a + b;
    }

    public (int, int) GetMinMax(int[] numbers) { // You can return multiple values using Tuples.
        return (numbers.Min(), numbers.Max());
    }

    public void GetMinMax(int[] numbers, out int min, out int max) { // You can return multiple values using out parameters.
        min = numbers.Min();
        max = numbers.Max();
    }

}