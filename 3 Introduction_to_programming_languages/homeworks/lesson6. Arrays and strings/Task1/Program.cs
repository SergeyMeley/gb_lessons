// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 
// a b c => “abcdef”
// d e f 

char[,] array = 
{
    { 'a', 'b', 'c', },
    { 'd', 'e', 'f', },
};

string GetStringByArray(char[,] arr)
{
    string result = "";
    foreach(char item in arr)
    {
        result += item;
    }
    return result;
}

Console.WriteLine(GetStringByArray(array));