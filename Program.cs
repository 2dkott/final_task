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

string[] checkArray(string[] inputArray) {
    int tempLength = 0;
    for (int i = 0; i < inputArray.Length; i++) { 
        if(inputArray[i].Length<4 && !string.IsNullOrEmpty(inputArray[i])) {
            tempLength++;
        }
    }
    string[] tempArray = new string[tempLength];
    int tempIdex = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length < 4 && !string.IsNullOrEmpty(inputArray[i])) {
            tempArray[tempIdex] = inputArray[i];
            tempIdex++;
        }
    }
    return tempArray;
}

string[] inputArray = generateArray(8);
printArray(inputArray);
string[] checkedArray = checkArray(inputArray);
printArray(checkedArray);