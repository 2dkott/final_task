string[] generateArray(int arraySize)
{
    string[] templateArray = new[] { "Тыква", "Сыр", "Кот", "Земля", "Диван", "Мир", ";-)", "Печь", "Нос"};
    Console.WriteLine("Генерация массива...");
    int[] numbers = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        numbers[i] = templateArray[new Random().Next(0, templateArray.GetLength-1)];
    }
    Console.WriteLine("Генерация массива закончена");
    return numbers;
}

void printArray(int[] array)
{
    Console.WriteLine("Печать массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        string divider = i < array.GetLength - 1 ? " ," : "\n";
        Console.WriteLine(array[i]);
    }
}

