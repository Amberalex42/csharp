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

int[] DestroyToLine(int[,] array)
{
    int[] result = new int[array.GetLength(0) * array.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[k] = array[i, j];
            k++;
        }
    }
    return result;
}

int[] SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[i])
            {
                (array[i], array[j]) = (array[j], array[i]);
            }
        }
    }
    return array;
}

int[,] BuildNewArray(int[] array, int rows, int cols)
{
    int[,] result = new int[rows, cols];
    int k = 0;
    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result[i, j] = array[k];
            k++;
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
Console.WriteLine("----------------------");
int[,] newMas = BuildNewArray(SortArray(DestroyToLine(mas)), m, n);
PrintArray(newMas);