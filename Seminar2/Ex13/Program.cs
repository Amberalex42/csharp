Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100)
{
    Console.WriteLine("Третьей цифры у числа нет");
}
else
{
   while (a > 999)
   {
    a = a / 10;
   }
    Console.WriteLine(a % 10);
}