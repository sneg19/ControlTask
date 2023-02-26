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

 string[] ConditionCheck(string[] strArray, int size)
{
    string[] strMatrix = new string[size];
    for(int i = 0; i < strArray.Length; i++)
    {
        if(strArray[i].Length < 4) 
        {
            strMatrix[i] = strArray[i];
            i++;
        }
    }
    return strMatrix; 
}

int UserInput()
{
    System.Console.Write("Укажите необходимый размер массива: ");
    int size = int.Parse(Console.ReadLine()!);
    return size;
}

