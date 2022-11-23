// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] NewArray(string[] s, int n)
{
    string[] res = new string[CountIndex(s, n)];

    for (int i = 0, j = 0; i < s.Length; i++)
    {
        if (s[i].Length <= 3)
        {
            res[j] = s[i];
            j++;
        }
    }
    return res;
}

int CountIndex(string[] s, int n)
{
    int count = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}

Console.Clear();
Console.Write("Введите массив из строк через пробел: ");
string[] str = Console.ReadLine()!.Split(" ");
int numOfChar = 3;
string[] array = NewArray(str, numOfChar);
Console.WriteLine($"[{String.Join(", ", str)}] -> [{String.Join(", ", array)}]");