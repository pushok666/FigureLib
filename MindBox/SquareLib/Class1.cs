namespace SquareLib;
public class Class1
{
    private const double pi = 3.14;

    
    public double SquareCircle(double r)
    {
        return pi * Math.Pow(r,2);
    }

    public double SquareTriangle(double a, double b, double c)
    {
        double p = (a+b+c)/2;
        return Math.Sqrt(p * (p-a) * (p-b) * (p-c));
    }

    public double SquareQuadrilateral(double a, double b)
    {
        return a * b;
    }

    public double SquareTruePoligon(double a, List<double> sides)
    {
        double sum = 0;
        foreach(var side in sides)
            sum += side;
        return (a * sum)/2;
    }

    public bool CheckTringle(double a, double b, double c)
    {
        var result = false;
        if(Math.Pow(a,2) + Math.Pow(b,2) - Math.Pow(c,2)/(2*a*b) == 0)
            result = true;
        return result;
    }
}
