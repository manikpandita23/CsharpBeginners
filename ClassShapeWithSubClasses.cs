using System;

class Shape
{
    public virtual void Draw() => Console.WriteLine("Drawing a generic shape...");
    public virtual void Erase() => Console.WriteLine("Erasing the shape...");
}

class Circle : Shape { public override void Draw() => Console.WriteLine("Drawing a circle..."); }
class Triangle : Shape { public override void Draw() => Console.WriteLine("Drawing a triangle..."); }
class Square : Shape { public override void Draw() => Console.WriteLine("Drawing a square..."); }

class Program
{
    static void Main()
    {
        Shape shape1 = new Circle();
        shape1.Draw();
        shape1.Erase();

        Shape shape2 = new Triangle();
        shape2.Draw();
        shape2.Erase();

        Shape shape3 = new Square();
        shape3.Draw();
        shape3.Erase();

        Console.ReadKey();
    }
}
