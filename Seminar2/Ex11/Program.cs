Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string result = "";
int digit;
while (a > 0)
{
    digit = a % 10;
    if (a < 10 || a > 99)
    {
        result = Convert.ToString(digit) + result;
    }
    a = a / 10;
}
Console.WriteLine(result);

//Решение через логарифм:
// int k = Convert.ToInt32(Math.Log10(a)) + 1;
// int firstPart = Convert.ToInt32(a / Math.Pow(10, k - 1));
// int secondPart = Convert.ToInt32(a % Math.Pow(10, k - 2));
// Console.WriteLine($"{firstPart}{secondPart}");