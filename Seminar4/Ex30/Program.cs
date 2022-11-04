int[] getArray()
{
    int[] result = new int[8];
    for (int i = 0; i < 8; i++)
    {
        result[i] = new Random().Next(0, 2);
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

bool isMore1(int[] array)
{
    int total = 0;
    for(int i = 0; i < 8; i++) total += array[i];
    if(total > 4) return true;
    else return false;
}

int[] myArray = getArray();
PrintArray(myArray);
Console.WriteLine(isMore1(myArray));