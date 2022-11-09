Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int calcSum(int m, int n)
{
    if(n == m)
    {
        return m;
    }
    else
    {
        return n + calcSum(m, n - 1);
    }
}

Console.WriteLine(calcSum(m, n));