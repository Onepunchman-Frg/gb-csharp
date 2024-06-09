int n = 10;
int[] arr = new int[n];

fillArray(arr);
printArray(arr);

int sum = sumArr(arr);
int product = prodArr(arr);

Console.WriteLine();
Console.WriteLine(sum);
Console.WriteLine(product);

void fillArray(int[] inArr) {
    int i = 0;
    while (i < inArr.Length) {
        inArr[i] = i + 1;
        i++;
    }
}

void printArray(int[] inArr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int sumArr(int[] inArr) {
    int i = 0;
    int sum = 0;
    while (i < inArr.Length) {
        sum += inArr[i];
        i++;
    }
    return sum;
}

int prodArr(int[] inArr) {
    int i = 0;
    int product = 1;
    while (i < inArr.Length) {
        product *= inArr[i];
        i++;
    }
    return product;
}