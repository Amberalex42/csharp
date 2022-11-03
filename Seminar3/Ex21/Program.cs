Console.WriteLine("Введите первую координату первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью координату первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую координату второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью координату второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(getDist(x1, y1, z1, x2, y2, z2));

double getDist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
}

