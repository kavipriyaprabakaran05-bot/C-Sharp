using System;
class Employee
{
    public string employeeName;
    public decimal basicSalary;
    public decimal hra;
    public decimal da;
    public decimal tax;
    public decimal grossPay;
    public decimal netPay;
    public Employee(string name, decimal salary)
    {
        employeeName = name;
        basicSalary = salary;
    }
    public void CalculateNetPay()
    {
        hra = basicSalary * 0.15m;
        da = basicSalary * 0.10m;
        grossPay = basicSalary + hra + da;
        tax = grossPay * 0.08m;
        netPay = grossPay - tax;
    }
    public void Display()
    {
        Console.WriteLine("Employee Name : " + employeeName);
        Console.WriteLine("Basic Salary  : " + basicSalary);
        Console.WriteLine("HRA (15%)     : " + hra);
        Console.WriteLine("DA (10%)      : " + da);
        Console.WriteLine("Gross Pay     : " + grossPay);
        Console.WriteLine("Tax (8%)      : " + tax);
        Console.WriteLine("Net Pay       : " + netPay);
    }
}
class Stock
{
    public string stockName;
    public string stockSymbol;
    public double previousClosingPrice;
    public double currentClosingPrice;
    public Stock(string name, string symbol, double prevPrice, double currPrice)
    {
        stockName = name;
        stockSymbol = symbol;
        previousClosingPrice = prevPrice;
        currentClosingPrice = currPrice;
    }
    public double getChangePercentage()
    {
        return ((currentClosingPrice - previousClosingPrice) / previousClosingPrice) * 100;
    }
}

class RandomHelper
{
    static Random rand = new Random();
    public static int randint(int min, int max)
    {
        return rand.Next(min, max + 1);
    }
    public static double randdouble(int min, int max)
    {
        return rand.NextDouble() * (max - min) + min;
    }
}
class Program
{
    static void Main()
    {
        Employee emp = new Employee("John Doe", 50000);
        emp.CalculateNetPay();
        emp.Display();
        Stock s = new Stock("Apple Inc.", "AAPL", 150.50, 155.75);
        Console.WriteLine("Stock Price Change: " + s.getChangePercentage() + "%");
        Console.WriteLine("Random Integer (1–10): " + RandomHelper.randint(1, 10));
        Console.WriteLine("Random Double (1–10): " + RandomHelper.randdouble(1, 10));
    }
}
