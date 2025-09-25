class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Add: " + Calculator.Add(5, 3)); // 8
        Console.WriteLine("Subtract: " + Calculator.Subtract(5, 3)); // 2
        Console.WriteLine("Multiply: " + Calculator.Multiply(5, 3)); // 15
    }
}