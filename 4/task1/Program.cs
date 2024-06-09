int[,] createTable(int rowCount, int colCount)
{
    int[,] table = new int[rowCount, colCount];
    Random rnd = new Random();

    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(1, 11);
        }
    }
    return table;
}

void showTable(int[,] inputTable)
{
    for (int i = 0; i < inputTable.GetLength(0); i++)
    {
        for (int j = 0; j < inputTable.GetLength(1); j++)
        {
            Console.Write($"{inputTable[i, j]} ");
        }
        Console.WriteLine($" ");
    }
}


int[,] talbeTest = createTable(4,8);
showTable(talbeTest);