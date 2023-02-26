// // Написать программа, которая создает массив из строк данного массива. которые по длинне меньше 3-х символов

string[] GetArray(int size)
{
    string[] strArray = new string[size];
    for(int i = 0; i < strArray.Length; i++)
    {
        System.Console.Write($"Введите стрококу, которая запишется в {i}-й элемент массива: ");
        strArray[i] = Console.ReadLine()!;
    }
    return strArray[];
}

 