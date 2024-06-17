int fact(int n)
{
    if (n == 1 || n == 0)
    {
        return 1;
    }
    Console.WriteLine($"{n}");
    return n * fact(n - 1);
}

Console.WriteLine(fact(8));
