int[,] FillArray(int rows, int cols)
{
    int[,] result = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result[i, j] = new Random().Next(1, 21);
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

int[] FindNum(int[,] array, int num)
{
    int[] result = new int[] { -1, -1 };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                result[0] = i;
                result[1] = j;
                break;
            }
        }
    }
    return result;
}

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] mas = FillArray(m, n);
PrintArray(mas);
Console.WriteLine();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] result = FindNum(mas, num);
if (result[0] == -1)
{
    Console.WriteLine("Такого числа в массиве нет.");
}
else
{
    Console.WriteLine($"Позиция данного числа в массиве: [{result[0]}, {result[1]}]");
}