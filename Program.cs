// // Написать программа, которая создает массив из строк данного массива. которые по длинне меньше 3-х символов

string[] GetArray(int size)
{
    string[] strArray = new string[size];
    for(int i = 0; i < strArray.Length; i++)
    {
        System.Console.Write($"Введите стрококу, которая запишется в {i}-й элемент массива: ");
        strArray[i] = Console.ReadLine()!;
    }
    return strArray;
}

 string[] ConditionCheck(string[] strArray)
{
    int newSize = 0;
    for (int i = 0; i < strArray.Length; i++)
    {
        if (strArray[i].Length < 4)
        {
            newSize++;
        }
    }
           
    string[] strMatrix = new string[newSize];
    int newK = 0;
    for (int j = 0; j < strArray.Length; j++)
    {
        if (strArray[j].Length < 4)
        {
            strMatrix[newK++] = strArray[j];
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

void Main()
{
    int sizeArray = UserInput();
    string[] ourArray = GetArray(sizeArray);
    string[] strMatrix = ConditionCheck(ourArray);
    Console.WriteLine(string.Join(",", ourArray));
    Console.WriteLine(string.Join(",", strMatrix));
}

Main();