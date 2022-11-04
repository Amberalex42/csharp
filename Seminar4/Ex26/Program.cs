Console.WriteLine("Введите число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(getCount(a));

int getCount(double num)
{
    int result = 0;
    while (num != Convert.ToInt32(num))
    {
        num *= 10;
    }
    int intNum = Convert.ToInt32(num);
    while (intNum > 0){
        result++;
        intNum /= 10;
    }
    return result;
}
