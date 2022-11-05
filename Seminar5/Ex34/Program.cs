int[] FillArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++) result[i] = new Random().Next(100, 1000);
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

int calcEven(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) counter++;
    }
    return counter;
}

int[] a = FillArray(10);
printArray(a);
Console.WriteLine(calcEven(a));