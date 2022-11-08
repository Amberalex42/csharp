int[,] FillArray(int rows, int cols)
{
    int[,] result = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result[i, j] = new Random().Next(1, 10);
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

int[,] MultiMatrix(int[,] a, int[,] b)
{
    int[,] result = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int total = 0;
            for(int k = 0; k < a.GetLength(1); k++)
            {
                total += a[i, k] * b[k, j];
            }
            result[i, j] = total;
        }
    }
    return result;
}

Console.WriteLine("Введите количество строк первой матрицы: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы: ");
int r2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int c2 = Convert.ToInt32(Console.ReadLine());
while (c1 != r2)
{
    Console.WriteLine("Количество столбцов первой матрицы должно совпадать с количеством строк второй матрицы.");
    Console.WriteLine("Введите количество строк первой матрицы: ");
    r1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов первой матрицы: ");
    c1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество строк второй матрицы: ");
    r2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов второй матрицы: ");
    c2 = Convert.ToInt32(Console.ReadLine());
}
int[,] a = FillArray(r1, c1);
PrintArray(a);
Console.WriteLine();
int[,] b = FillArray(r2, c2);
PrintArray(b);
Console.WriteLine();
int[,] c = MultiMatrix(a, b);
PrintArray(c);