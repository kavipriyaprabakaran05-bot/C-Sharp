using System;
class GeometryTool
{
    public double Perimeter(double side)
    {
        return 4 * side;
    }
    public double Perimeter(double length, double breadth)
    {
        return 2 * (length + breadth);
    }
    public double Perimeter(double a, double b, double c)
    {
        return a + b + c;
    }
    public double Perimeter(double radius, bool isCircle)
    {
        if (isCircle)
        {
            return 2 * Math.PI * radius;
        }

        return 0; 
    }
}
class Program
{
    static void Main()
    {
        GeometryTool tool = new GeometryTool();
        Console.WriteLine("Square Perimeter: " + tool.Perimeter(5));       
        Console.WriteLine("Rectangle Perimeter: " + tool.Perimeter(4, 7));     
        Console.WriteLine("Triangle Perimeter: " + tool.Perimeter(3, 4, 5));  
        Console.WriteLine("Circle Perimeter: " + tool.Perimeter(3.5, true));  
    }
}
