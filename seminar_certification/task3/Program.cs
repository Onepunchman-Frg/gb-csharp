// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void Main()
{
    int arraySize = ReadInt("Введите длину массива: ");
    int[] array = generateArray(arraySize, 0, 1000);
    printArray(array);
    printArrayReverse(array, arraySize - 1);
}

void printArrayReverse(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }

    Console.Write(array[index] + " ");
    printArrayReverse(array, index - 1);
}

int[] generateArray(int size, int minRange, int maxRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
        tempArray[i] = rand.Next(minRange, maxRange + 1);

    return tempArray;
}

void printArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();