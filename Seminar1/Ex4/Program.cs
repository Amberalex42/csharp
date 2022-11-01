Console.WriteLine("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
double c = Convert.ToDouble(Console.ReadLine());
double result;
if (a > b)
{
    if (a > c)
    {
        result = a;
    }
    else
    {
        result = c;
    }
}
else
{
    if (b > c)
    {
        result = b;
    }
    else
    {
        result = c;
    }
}
Console.WriteLine($"Максимальное число: {result}.");