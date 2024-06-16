int[,] createTable(int rowCount, int colCount)
{
    int[,] table = new int[rowCount, colCount];
    Random rnd = new Random();

    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(1, 4000);
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

int[,] matrix = createTable(4, 8);
showTable(matrix);

foreach (int e in matrix)
{
    if (isInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}

bool isInteresting(int value)
{
    int sumOfDigit = getSumOfDigit(value);
    if (sumOfDigit % 2 == 0) {
        return true;
    }
    return false;
}

int getSumOfDigit(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10;
        value /= 10;
    }

    return sum;
}

