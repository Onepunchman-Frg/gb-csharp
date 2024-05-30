int[] arr = { 2, 3, 4, 5, 7, 5, 6, 7, 89, 4 };
int i = 0;

while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i++;
}


