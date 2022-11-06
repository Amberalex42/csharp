double[] getCoords(double b1, double k1, double b2, double k2)
{
    double[] res;
    if (k1 == k2)
    {
        res = new double[0];
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        res = new double[] { x, y };
    }
    return res;
}

Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] coords = getCoords(b1, k1, b2, k2);
if (coords.Length == 0)
{
    Console.WriteLine("Графики фукнций не пересекаются");
}
else
{
    Console.WriteLine($"({coords[0]}; {coords[1]})");
}
