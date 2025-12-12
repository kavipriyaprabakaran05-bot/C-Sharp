using System;
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
    public double Add(double a, double b, double c)
    {
        return a + b + c;
    }
    public int Multiply(int a, int b)
    {
        return a * b;
    }
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    public int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }
    public int Subtract(int a, int b)
    {
        return a - b;
    }
    public double Subtract(double a, double b)
    {
        return a - b;
    }
}
class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Console.WriteLine("===== ADD RESULTS =====");
        Console.WriteLine("Add(int, int): " + calc.Add(10, 20));
        Console.WriteLine("Add(int, int, int): " + calc.Add(1, 2, 3));
        Console.WriteLine("Add(double, double): " + calc.Add(5.5, 4.3));
        Console.WriteLine("Add(double, double, double): " + calc.Add(1.2, 2.3, 3.4));

        Console.WriteLine("\n===== MULTIPLY RESULTS =====");
        Console.WriteLine("Multiply(int, int): " + calc.Multiply(5, 6));
        Console.WriteLine("Multiply(double, double): " + calc.Multiply(2.5, 4.0));
        Console.WriteLine("Multiply(int, int, int): " + calc.Multiply(2, 3, 4));

        Console.WriteLine("\n===== SUBTRACT RESULTS =====");
        Console.WriteLine("Subtract(int, int): " + calc.Subtract(20, 5));
        Console.WriteLine("Subtract(double, double): " + calc.Subtract(10.5, 2.25));
    }
}
