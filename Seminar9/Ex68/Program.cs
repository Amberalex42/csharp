Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ankkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ankkerman(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ankkerman(m - 1, Ankkerman(m, n - 1));
    }
    else
    {
        return -1;
    }
}

int res = Ankkerman(m, n);
if (res == -1)
{
    Console.WriteLine("Произошла ошибка");
}
else
{
    Console.WriteLine(res);
}