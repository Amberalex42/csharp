Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] a = FillArray(m, n);
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}
FindMinMax(a);

int[,] FillArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 100);
        }
    }
    return result;
}

void FindMinMax(int[,] array)
{
    int minRow = 0;
    int minCol = 0;
    int maxRow = 0;
    int maxCol = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (array[i, j] > array[maxRow, maxCol])
            {
                maxRow = i;
                maxCol = j;
            }
            if (array[i, j] < array[minRow, minCol])
            {
                minRow = i;
                minCol = j;
            }
        }
    }
    Console.WriteLine($"Минимальный элемент: {array[minRow, minCol]}, его индекс: ({minRow}, {minCol}).");
    Console.WriteLine($"Максимальный элемент: {array[maxRow, maxCol]}, его индекс: ({maxRow}, {maxCol}).");
}