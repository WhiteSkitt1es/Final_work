// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] InputArray()
{
    Console.WriteLine("Введите количество элементов массива: ");

    int elementsCount = int.Parse(Console.ReadLine()!);

    string [] massive = new string [elementsCount];

    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write($"Введите строку элемента массива под номером {i + 1}: ");
        massive[i] = Console.ReadLine()!;
    }
    return massive;
}

string[] array1 = InputArray();

string [] CreateSecondArray (string[] massive)
{
    int count = 0;

    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i].Length <=3)
        {
            count++;
        }
    }
    
    string[] newArray = new string [count];
    return newArray;

}

string[] array2 = CreateSecondArray(array1);

void SortingArray(string[] array1,string[] array2)
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (index <= array2.Length)
        {
            if (array1[i].Length <= 3)
            {
                array2[index] = array1[i];
                index ++;
            }
        }

    }
    Console.WriteLine(string.Join(',', array2));
}

SortingArray(array1,array2);











// Console.WriteLine(string.Join(',', array));