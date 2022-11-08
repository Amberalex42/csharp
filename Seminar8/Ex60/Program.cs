int[,,] FillArray(int m, int n, int o)
{
    int[,,] result = new int[m, n, o];
    int[] usedNums = new int[m * n * o];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for(int k = 0; k < o; k++)
            {
                int rand = new Random().Next(10, 100);
                while (NumInArray(rand, usedNums))
                {
                    rand = new Random().Next(10, 100);
                }
                result[i, j, k] = rand;
            }
        }
    }
    return result;
}

bool NumInArray(int num, int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(2); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(0); k++)
            {
                Console.Write($"{array[j, k, i]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите первое измерение: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе измерение: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье измерение: ");
int o = Convert.ToInt32(Console.ReadLine());
int[,,] a = FillArray(m, n, o);
PrintArray(a);