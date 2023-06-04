// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] PrintArray()
{
    Console.WriteLine("Введите количество элементов массива");

    int elementsCount = int.Parse(Console.ReadLine()!);

    string [] massive = new string [elementsCount];

    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write($"Введите число элемента массива под номером {i + 1}: ");
        massive[i] = Console.ReadLine()!;
    }
    return massive;
}
PrintArray();

string [] array = PrintArray();

string [] CreateSecondArray (string[] array)
{
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        string text = array[i];
        if (text.Length <= 3)
        {
            index ++;
        }
    }
    
    string[] newArray = new string [index];
    return newArray;

}

CreateSecondArray(array);













// Console.WriteLine(string.Join(',', array));