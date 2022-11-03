Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(getCubes(a));

string getCubes(int num)
{
    string result = "";
    for(int i = 1; i < num; i++)
    {
        result += $"{Math.Pow(i, 3)}, ";
    }
    result += $"{Math.Pow(num, 3)}";
    return result;
}