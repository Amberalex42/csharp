double[] FillArray(int size)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++) result[i] = Math.Round(new Random().NextDouble() * 20 - 10, 2);
    return result;
}

void printArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double calcDiff(double[] array)
{
    double maxValue = array[0];
    double minValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxValue) maxValue = array[i];
        if (array[i] < minValue) minValue = array[i];
    }
    return maxValue - minValue;
}

double[] a = FillArray(10);
printArray(a);
Console.WriteLine(calcDiff(a));

    