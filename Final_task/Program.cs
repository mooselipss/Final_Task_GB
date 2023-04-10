// Задача: 
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите количесво строк: ");
int userArraySize = int.Parse(Console.ReadLine()!);

// Инициализирую пользовательский массив строк нужного размера
string[] InitUserArray(int size)
{
    string[] array = new string[size];
    return array;
}

// Заполняю массив значениями введенными пользователем
void FillArray(string[] array)
{
    int j = 0;
    for (int i = 1; i <= userArraySize; i++)
    {
        Console.WriteLine($"Введите {i} строку");
        array[j] = Console.ReadLine()!;
        j++;
    }
}

// Вывожу массив, который ввел пользователь в консоль
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else
        {
            Console.Write($"{array[i]}]");
            Console.WriteLine();
        }

    }
    if (array.Length == 0) Console.WriteLine("[]");
}

// Считаю количество элементов для заполнения результирующего массива
int GetResultArraySize(string[] array)
{
    int resultArraySize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) resultArraySize++;
    }
    return resultArraySize;
}

// Заполняю массив валидными элементами
void FillResultArray(string[] userArray, string[] resultArray)
{
    int resultArrElem = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= 3)
        {
            resultArray[resultArrElem] = userArray[i];
            resultArrElem++;
        }
        
    }
}

string[] userArray = InitUserArray(userArraySize);
FillArray(userArray);
Console.WriteLine();
PrintArray(userArray);
int resArraySize = GetResultArraySize(userArray);
string[] resArray = InitUserArray(resArraySize);
FillResultArray(userArray, resArray);
Console.WriteLine();
PrintArray(resArray);