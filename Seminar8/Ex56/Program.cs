int[,] FillArray(int rows, int cols)
{
    int[,] result = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result[i, j] = new Random().Next(1, 101);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int calcMinSum(int[,] array)
{
    int minSum = 0;
    int minIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int total = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            total += array[i, j];
        }
        Console.WriteLine($"В строке {i} сумма {total}");
        if (i == 0)
        {
            minSum = total;
        }
        else
        {
            if (total < minSum)
            {
                minSum = total;
                minIndex = i;
            }
        }
    }
    return minIndex;
}

Console.WriteLine("Введите количество строк и столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] a = FillArray(m, m);
PrintArray(a);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {calcMinSum(a) + 1}");