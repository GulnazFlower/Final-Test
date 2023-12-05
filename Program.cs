// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string[] GenerateNewArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int newIndex = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[newIndex] = array[i];
            newIndex++;
        }
    }
    return newArray;
}   

string[] GenerateArray()
{
    Console.Write("Введите количество элементов массива:\t");
    int size = int.Parse(Console.ReadLine());
    string[] array = new string[size];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t");
        array[i] = Console.ReadLine();
    }
    return array;
}   

string[] array = GenerateArray();
string[] newArray = GenerateNewArray(array);
Console.Write($"[{String.Join(",", array)}] -> ");
GenerateNewArray(array);
Console.WriteLine($"[{String.Join(",", newArray.Where(e => ! string.IsNullOrEmpty(e)))}]");