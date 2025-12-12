using System;
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}
class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}
class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a triangle");
    }
}
class Program
{
    static void Main()
    {
        Shape shapeRef;
        shapeRef = new Circle();
        shapeRef.Draw(); 
        shapeRef = new Rectangle();
        shapeRef.Draw(); 
        shapeRef = new Triangle();
        shapeRef.Draw();  
    }
}
