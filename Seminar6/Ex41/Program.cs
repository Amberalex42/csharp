

Console.WriteLine("Сколько чисел будете вводить?");
int m = Convert.ToInt32(Console.ReadLine());
int[] a = new int[m];
for(int i = 0; i < m; i++)
{
    Console.WriteLine($"Введите {i + 1} число: ");
    a[i] = Convert.ToInt32(Console.ReadLine());
}
