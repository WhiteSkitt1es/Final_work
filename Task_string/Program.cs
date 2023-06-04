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
    Console.WriteLine(string.Join(',', massive));

    return massive;
}



PrintArray();









// Console.WriteLine(string.Join(',', array));