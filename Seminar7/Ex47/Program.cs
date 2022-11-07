double[,] FillArray(int rows, int cols)
{
    double[,] result = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 2);
        }
    }
    return result;
}

void PrintArray(double[,] array)
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

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] mas = FillArray(m, n);
PrintArray(mas);