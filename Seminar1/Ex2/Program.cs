Console.WriteLine("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
double max = a;
double min = b;
if (b > a)
{
    max = b;
    min = a;
}
Console.WriteLine($"Большее число: {max}, меньшее число: {min}.");