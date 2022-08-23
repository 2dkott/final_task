string[] generateArray(int arraySize)
{
    string[] templateArray = new[] { "Тыква", "Сыр", "Кот", "Земля", "Диван", "Мир", ";-)", "Печь", "Нос"};
    Console.WriteLine("Генерация массива...");
    string[] numbers = new string[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        int index = new Random().Next(0, templateArray.Length - 1);
        numbers[i] = templateArray[index];
    }
    Console.WriteLine("Генерация массива закончена");
    return numbers;
}

void printArray(string[] array)
{
    Console.WriteLine("Печать массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        string divider = i < array.Length - 1 ? "," : "\n";
        Console.WriteLine(array[i] + divider);
    }
}

string[] temp = generateArray(8);
printArray(temp);