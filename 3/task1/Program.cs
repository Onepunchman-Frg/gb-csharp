// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


double calcFunc(int a, int b, int c, int d)
{
    double numenator = a * b;
    double denomenator = c + d;

    double res = numenator / denomenator;
    return res;
};

Console.WriteLine(calcFunc(2, 3, 4, 5));

