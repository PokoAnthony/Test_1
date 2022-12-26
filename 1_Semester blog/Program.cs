// Задача № 4: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 
// 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
// задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// 1. Заполнить 3 одномерных массива.
Console.Clear();
string[] arr1 = {"Hello","2","world",":-)"};
string[] arr2 = {"1234","1567","-2","computer science"};
string[] arr3 = {"Russia","Denmark","Kazan"};

int maxLength = 3;

// 2. проверка количества символов
string[] СharacterСountСheck(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}

// 3. Функция вывод на печать массива	
void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Массив пуст.");
    }
    else
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
}

// 4. Вывод на печать условий задачи		
void PrintTask(string[] array)
{
    Console.WriteLine("Первоначальный массив: ");
    PrintArray(array);
    string[] shortArray = СharacterСountСheck(array);
    Console.WriteLine($"Итоговый массив (слова, в которых меньше или {maxLength} символа)");
    PrintArray(shortArray);
    Console.WriteLine();
}

// 5. Вывод на печать функции	
PrintTask(arr1);
PrintTask(arr2);
PrintTask(arr3);