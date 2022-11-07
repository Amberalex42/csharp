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

int[] ShuffleArray(int[] array)
{
    List<int> counter = new List<int>(array.Length);
    for(int i = 0; i < array.Length; i++) counter.Add(i);
    int iter = 0;
    while(counter.Count > 0)
    {
        int randIndex = new Random().Next(0, counter.Count);
        int a = counter[randIndex];
        counter.RemoveAt(randIndex);
        randIndex = new Random().Next(0, counter.Count);
        int b = counter[randIndex];
        counter.RemoveAt(randIndex);
        (array[a], array[b]) = (array[b], array[a]);
        iter++;
    }
    Console.WriteLine($"Перемешали за {iter} итераций.");
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
while (m * n % 2 == 1)
{
    Console.WriteLine("Количество элементов массива должно быть четным.");
    Console.WriteLine("Введите количество строк: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    n = Convert.ToInt32(Console.ReadLine());
}

int[,] mas = FillArray(m, n);
PrintArray(mas);
Console.WriteLine();
int[] temp = DestroyToLine(mas);
int[] shuffledTemp = ShuffleArray(temp);
Console.WriteLine();
int[,] newTemp = BuildNewArray(shuffledTemp, m, n);
PrintArray(newTemp);