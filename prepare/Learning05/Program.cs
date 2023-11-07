using System;

class Program
{
    static void Main(string[] args)
    {
       List<Shape> shapes = new List<Shape>();

       Square shape1 = new Square("Red", 4);
       shapes.Add(shape1);

       Rectangle shape2 = new Rectangle("Blue", 3, 6);
       shapes.Add(shape2);

       Circle shape3 = new Circle("Yellow", 5);
       shapes.Add(shape3);

       foreach (Shape shape in shapes)
       {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"This {color} shape has an area of {area}");
       }
    }
}