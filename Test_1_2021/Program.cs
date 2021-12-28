int[] CreateArray()
{
    int lenght = Convert.ToInt32(Console.ReadLine());
    return new int[lenght];
}

int[] FillArray(int[] array)
{
    int min = Convert.ToInt32(Console.ReadLine());
    int max = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

string PrintArray(int[] array)
{
    string text = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        text = text + $"{array[i]} ";
    }
    return text;
}

int FindLenght(int[] array)
{
    int newLenght = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            newLenght++;
        }
    }
    return newLenght;
}

int[] FillNewArray(int[] array)
{
    int newLenth = FindLenght(array);
    int[] newArray = new int[newLenth];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] % 2 == 0)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}



void TestMethods()
{
    int[] firstArray = CreateArray();
    FillArray(firstArray);
    Console.WriteLine(PrintArray(firstArray));
    Console.WriteLine();
    int[] secondArray = FillNewArray(firstArray);
    Console.WriteLine(PrintArray(secondArray));
}

TestMethods();