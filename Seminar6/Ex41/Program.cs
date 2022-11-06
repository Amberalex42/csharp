int[] FillArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}

int calcPositive(int[] array)
{
    int total = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) total++;
    }
    return total;
}

Console.WriteLine("Сколько чисел будете вводить?");
int m = Convert.ToInt32(Console.ReadLine());
int[] a = FillArray(m);
int res = calcPositive(a);
Console.WriteLine(res);


