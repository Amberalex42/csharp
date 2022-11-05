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

int calcSumOdd(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        result += array[i];
    }
    return result;
}

int[] a = FillArray(11);
printArray(a);
Console.WriteLine(calcSumOdd(a));