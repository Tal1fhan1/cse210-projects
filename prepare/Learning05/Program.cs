using System;

class Program
{
    static void Main(string[] args)
    {
        Square sqr = new Square("blue", 2.00);

        Rectangle rec = new Rectangle("red", 2.00, 5.00);

        Circle cir = new Circle("green", 3.00);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(sqr);
        shapes.Add(rec);
        shapes.Add(cir);
        foreach(Shape s in shapes)
        {
            Console.WriteLine($"Color: {s.GetColor()}");
            Console.WriteLine($"Area: {s.GetArea()} cm^2");
            Console.WriteLine();
        }

    }
}