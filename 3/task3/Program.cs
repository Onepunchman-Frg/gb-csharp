﻿void zeroEven(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void printArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}


int[] array = { 1, 2, 3, 4, 5 };
zeroEven(array);
printArray(array);