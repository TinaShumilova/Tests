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
        array[i] = new Random().Next(min, max+1);
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

void TestMethods()
{
    int[] firstArray = CreateArray();
    FillArray(firstArray);
    Console.WriteLine(PrintArray(firstArray));
}

TestMethods();