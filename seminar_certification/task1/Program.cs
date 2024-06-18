// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void Main()
{
    int M = ReadInt("Введите начальное значение: ");
    int N = ReadInt("Введите конечное значение: ");

    printList(M, N);
}

void printList(int fNum, int lNum)
{
    if (fNum > lNum) return;

    Console.Write(fNum + " ");

    printList(fNum + 1, lNum);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();