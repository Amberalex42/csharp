string countProgrammers(int n)
{
    if (n % 100 >= 11 && n % 100 <= 14)
    {
        return $"{n} программистов";
    }
    else if (n % 10 == 1)
    {
        return $"{n} программист";
    }
    else if (n % 10 >= 2 && n % 10 <= 4)
    {
        return $"{n} программиста";
    }
    else
    {
        return $"{n} программистов";
    }
}

// Console.WriteLine("Введите количество программистов: ");
// int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 30; i++)
{
    Console.WriteLine(countProgrammers(i));
}
