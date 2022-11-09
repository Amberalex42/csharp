Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNum(int n)
{
    if(n == 1) Console.Write($"{n}");
    else Console.Write($"{n}, ");
    if(n > 1)
    {
        PrintNum(n - 1);
    }
    
}

PrintNum(n);