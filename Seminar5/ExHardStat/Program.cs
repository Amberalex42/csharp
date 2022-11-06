int[] FillArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++) result[i] = new Random().Next(-100, 101);
    return result;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void sortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[i]) (array[i], array[j]) = (array[j], array[i]);
        }
    }
}

double getMed(int[] array)
{
    sortArray(array);
    double result;
    if (array.Length % 2 == 1) result = array[array.Length / 2];
    else result = Convert.ToDouble(array[array.Length / 2] + array[array.Length / 2 - 1]) / 2;
    return result;
}

double[] getInfo(int[] array)
{

    int maxIndex = 0;
    int minIndex = 0;
    double total = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[maxIndex]) maxIndex = i;
        if (array[i] < array[minIndex]) minIndex = i;
        total += array[i];
    }
    double avg = Math.Round(total / array.Length, 2);
    double[] result = {array[maxIndex], maxIndex, array[minIndex], minIndex, avg, getMed(array)};
    return result;
}

int[] a = FillArray(10);
printArray(a);
double[] info = getInfo(a);
Console.WriteLine($"Максимальное значение: {info[0]}, индекс максимального значения : {info[1]}.");
Console.WriteLine($"Минимальное значение: {info[2]}, индекс минимального значения: {info[3]}.");
Console.WriteLine($"Среднее значение: {info[4]}.");
Console.WriteLine($"Медианное значение: {info[5]}.");
