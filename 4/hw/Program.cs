Console.WriteLine("Password: ");
string inputPas = Console.ReadLine();
char[] inputChar = inputPas.ToCharArray();

int getNumbersCount(char[] value)
{
    int count = 0;

    for (int i = 0; i < value.Length; i++)
    {
        if (Char.IsDigit(value[i]))
        {
            count++;
        }
    }
    return count;
}

int[] getNumbers(char[] value, int count)
{
    int[] resArr = new int[count];
    int i = 0;

    while (i < resArr.Length)
    {
        if (Char.IsDigit(value[i]))
        {
            resArr[i] = Convert.ToInt32(value[i]);
            Console.WriteLine(Convert.ToInt32(value[i].ToString()));
        }
        i++;
    }

    return resArr;
}

int numbersCount = getNumbersCount(inputChar);
Console.WriteLine(numbersCount);
int[] result = getNumbers(inputChar, numbersCount);
