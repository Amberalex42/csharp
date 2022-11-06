void getInfo(double a, double b, double c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("Треугольник существует");
        double p = (a + b + c) / 2;
        Console.WriteLine($"Площадь треугольника: {Math.Sqrt(p * (p - a) * (p - b) * (p - c))}");
        Console.WriteLine($"Периметр треугольника: {a + b + c}");
        Console.WriteLine($"Угол альфа: {Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI}");
        Console.WriteLine($"Угол бета: {Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI}");
        Console.WriteLine($"Угол гамма: {Math.Acos((c * c + b * b - a * a) / (2 * c * b)) * 180 / Math.PI}");
        if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
        {
            Console.WriteLine($"Треугольник прямоугольный");
        }
        if (a == b && b == c)
        {
            Console.WriteLine($"Треугольник равносторонний");
        }
        else if (a == b || a == c || b == c)
        {
            Console.WriteLine($"Треугольник равнобедренный");
        }
    }
    else
    {
        Console.WriteLine("Треугольник не существует");
    }
}

Console.WriteLine("Введите сторону a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите сторону b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите сторону c: ");
double c = Convert.ToDouble(Console.ReadLine());

getInfo(a, b, c);