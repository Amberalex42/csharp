int[] getArray()
{
    int[] result = new int[8];
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

int[] myArray = getArray();
PrintArray(myArray);