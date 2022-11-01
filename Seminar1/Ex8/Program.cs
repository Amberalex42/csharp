Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int index = 2;
while (index < n + 1)
{
    Console.Write(index);
    index += 2;
    if (index < n + 1)
    {
        Console.Write(", ");
    }
}