List<Shape> sizes = new List<Shape>
{
    new Circle(5),
    new Rectangle(5, 10),
    new Square(10)
};
double total = 0;

foreach (Shape i in sizes)
{
    
    i.PrintInfo();
    
    total += i.CalculateArea();
}
Console.WriteLine($"Total: {total}");


public abstract class Shape
{
    public abstract double CalculateArea();
    public void PrintInfo()
    {
        Console.WriteLine($"Area = {CalculateArea()}" );
    }
}

public class Circle : Shape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
        
    }
    public override double CalculateArea()
    {
        return 3.14 * Radius *Radius;
    }
    


}

public class Rectangle : Shape
{
    public double Width;
    public double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }

}

public class Square : Shape
{
    public double Size;

    public Square(double height)
    {
        Size = height;
    }

    public override double CalculateArea()
    {
        return Size * Size;
    }
}