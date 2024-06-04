void printSquare(int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i * i} ");
        i++;
    }
}

printSquare(2);
printSquare(3);
printSquare(4);