namespace Exam1;


public class Q1_Add
{
    public static int Add(int x, int y)
    {
        return x + y;
    }
}

public class Basics
{
    public static void Q2MultiplyAndReset(ref int v, ref int f)
    {
        v = v*f;
        f = 1;
    }

}

public class Q4Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Q4Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Introduce()
    {
        return $"Hello, my name is {Name} and I am {Age} years old.";
    }
}

public class Q6Temperature
{
    private global::System.Double fahrenheit;

    private global::System.Double celsius;

    public double Celsius 
    { 
        get => celsius; 
        set 
        { 
            fahrenheit = 32 + (((double) 9/5) *value);
            celsius = value;
        }
    }
    public double Fahrenheit 
    { 
        get => fahrenheit; 
        set 
        { 
            celsius = (double)5/9 * (value - 32);
            fahrenheit = value; 
        }
    }

}


public interface IShape
{
    public  double GetArea();
    public  double GetPerimeter();
}

public class Q7Circle: IShape
{
    public double radius { get; set; }
    
    public double GetArea()
    {
        return Math.PI * (radius*radius);
    }
    public double GetPerimeter()
    {
       return 2 * Math.PI * radius;
    }

    public Q7Circle(double r)
    {
        this.radius = r;
    }
}

public class Q7Rectangle: IShape
{
    public double L { get; set; }
    public double W { get; set; }

    public double GetArea()
    {
        return L * W;
    }
    public double GetPerimeter()
    {
        return 2*(L + W);
    }

    public Q7Rectangle(double l, double w)
    {
        this.L = l;
        this.W = w;
    }
}

public class ShapeUtils
{
    public static double Q7TotalArea(IShape[] shapes)
    {
        double total = 0;
        foreach (var item in shapes)
        {
            total += item.GetArea();
        }
        return total;
    }
}

