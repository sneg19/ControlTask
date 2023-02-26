// // Написать программа, которая создает массив из строк данного массива. которые по длинне меньше 3-х символов


string[] strArray = new string[4];
strArray[0] = "one";
strArray[1] = "twotwo";
strArray[2] = "thr";
strArray[3] = "four";

string[] strMatrix = new string[4];
for(int i=0; i<4; i++)
{
    if(strArray[i].Length < 4) 
    {
        strMatrix[i] = strArray[i];
    } 
}
System.Console.WriteLine(string.Join(",", strMatrix));
System.Console.WriteLine(string.Join(",", strArray));