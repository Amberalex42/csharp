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

string PrintOneDimensionArray(double[] array)
{
    string result = "";
    for (int i = 0; i < array.Length - 1; i++)
    {
        result += $"{array[i]}; ";
    }
    result += array[array.Length - 1];
    return result;
}

double[] FindAvg(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double total = 0;
        for (int i=0; i < array.GetLength(0); i++)
        {
            total += array[i, j];
        }
        result[j] = Math.Round(total / array.GetLength(0), 2);
    }
    return result;
}

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] mas = FillArray(m, n);
PrintArray(mas);
Console.WriteLine(PrintOneDimensionArray(FindAvg(mas)));
