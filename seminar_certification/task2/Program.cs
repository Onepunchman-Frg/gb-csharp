// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

void Main()
{
    int M = ReadInt("Введите значение m: ");
    int N = ReadInt("Введите значение n: ");

    int result = ackermannFunc(M, N);
    Console.WriteLine($"A({M}, {N}) = {result}");
}

int ackermannFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return ackermannFunc(m - 1, 1);
    }
    else // m > 0 && n > 0
    {
        return ackermannFunc(m - 1, ackermannFunc(m, n - 1));
    }
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();

