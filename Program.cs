void Main()
{
    Console.Clear();
    Console.WriteLine("Введите число строк, которые хотите ввести: ");
    int size = int.Parse(Console.ReadLine()!);
    string[] list = InputStrings(size);
    string[] newList = CreateArray(list, 3);
    PrintTwoArrays(list, newList);
}

string[] InputStrings(int s)
{
    string[] array = new string[s];
    for (int i = 1; i < array.Length + 1; i++)
    {
        Console.WriteLine($"Введите строку номер {i}: ");
        array[i - 1] = Console.ReadLine();
    }
    return array;
}

string[] CreateArray(string[] text, int length)
{
    string[] newText = new string[SpecificLength(text, length)];
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= length)
        {
            newText[count] = text[i];
            count++;
        }
    }
    return newText;
}

int SpecificLength(string[] arrayToChack, int length)
{
    int size = 0;
    for (int i = 0; i < arrayToChack.Length; i++)
    {
        if (arrayToChack[i].Length <= length)
        {
            size++;
        }
    }
    return size;
}

void PrintTwoArrays(string[] firstArray, string[] secondArray)
{
    Console.Clear();
    Console.Write($"[{String.Join(", ", firstArray)}] --> [{String.Join(", ", secondArray)}]");
}

Main();