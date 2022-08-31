
Console.WriteLine("enter the side 1:");
double side1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the side 2:");
double side2 = Convert.ToDouble(Console.ReadLine());
Rectangle a = new Rectangle(side1, side2);
a.AreaCalculator();
a.PerimeterCalculator();
Console.WriteLine($"Area = {a.Area}");
Console.WriteLine($"Perimeter = {a.Perimeter}");
class Rectangle
{
    double side1;
    double side2;
    public double Area 
    {
        get
        {
            return AreaCalculator();
        }  
    }
    public double Perimeter
    {
        get
        {
            return PerimeterCalculator();
        }
    }
    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
    public double AreaCalculator()
    {
      return (side1 * side2);
 
    }
    public double PerimeterCalculator()
    {
        return ((side1 + side2) * 2);

    }
}



