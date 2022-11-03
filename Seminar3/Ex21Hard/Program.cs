Console.WriteLine("Введите размерность пространства: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] coordsA = new int[n];
int[] coordsB = new int[n];
for(int i = 0; i < n ; i++)
{
    Console.WriteLine($"Введите {i + 1} координату точки А: ");
    coordsA[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i = 0; i < n ; i++)
{
    Console.WriteLine($"Введите {i + 1} координату точки B: ");
    coordsB[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(getDist(coordsA, coordsB));

double getDist(int[] coordsA, int[] coordsB)
{
    double total = 0;
    for (int i = 0; i < coordsA.Length; i++)
    {
        total += Math.Pow(coordsA[i] - coordsB[i], 2);
    }
    return Math.Round(Math.Sqrt(total), 2);
}