int[,] FillArray(int rows, int cols)
{
    int[,] result = new int[Convert.ToInt32(rows), Convert.ToInt32(cols)];
    int row = 0;
    int col = 0;
    int k = 1;
    int moveRow = 0;
    int moveCol = 1;

    while (k < rows * cols + 1)
    {
        result[row, col] = k;
        k++;
        if((col == 0 && moveCol == -1) || result[(row + moveRow) % rows, (col + moveCol) % cols] != 0) 
        {
            (moveRow, moveCol) = (moveCol, -moveRow);
        }
        row += moveRow;
        col += moveCol;
    }
    
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] a = FillArray(4, 4);
PrintArray(a);
