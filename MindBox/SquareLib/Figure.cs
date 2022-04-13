namespace SquareLib;

public class Figure
{
    private const double pi = 3.14;
    public double Result { get; set; }
    public Figure(double r)
    {
        var result = pi * Math.Pow(r,2);
        Result = result;
    }
    public Figure(double a, double b, double c)
    {
        double p = (a+b+c)/2;
        var result = Math.Sqrt(p * (p-a) * (p-b) * (p-c));
        Result = result;
    }

    public Figure(double a, double b)
    {
        var result = a * b;
        Result = result;
    }

    public Figure(double a, List<double> sides)
    {
        double sum = 0;
        foreach(var side in sides)
            sum += side;
        var result = (a * sum)/2;
        Result = result;
        
    }
}