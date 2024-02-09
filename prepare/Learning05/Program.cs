using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();
        Square square = new Square("blue",2);
        Rectangle rectangle = new Rectangle("red",2,3);
        Circle circle = new Circle("purple",5);
        shapeList.Add(square);
        shapeList.Add(rectangle);
        shapeList.Add(circle);
        Console.Clear();
        foreach (Shape shape in shapeList)
        {
            Console.WriteLine($"{shape} Color: {shape.GetColor()}");
            Console.WriteLine($"{shape} Area: {shape.GetArea()}");
            Console.WriteLine("");
        }
    }
}