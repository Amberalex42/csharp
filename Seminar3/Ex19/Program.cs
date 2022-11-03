int invert(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result * 10 + num % 10;
        num /= 10;
    }
    return result;
}

string isPalindrome(int a, int b)
{
    if (a == b) return "да";
    else return "нет";
}

Console.WriteLine("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int aInvert = invert(a);
Console.WriteLine(isPalindrome(a, aInvert));