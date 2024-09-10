// classes, modules, functions should be open for extension but closed for modification.
public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Rectangle : Shape
//  here rectangle inherits from shape but doesnt inherently changes shape
//  thus is open for extension but closed for modification
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class Circle : Shape
//  here circle inherits from shape but doesnt inherently changes shape
//  thus is open for extension but closed for modification
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class AreaCalculator
{
    public double CalculateArea(Shape[] shapes)
    {
        double area = 0;
        foreach (var shape in shapes)
        {
            area += shape.CalculateArea();
        }
        return area;
    }
}
