// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.
// “Hello my world” => “world my Hello”

Console.WriteLine("Введите преджложение:");
string inputString = Console.ReadLine();
Console.WriteLine(ReverseSentence(inputString));

string ReverseSentence(string str)
{
    string[] arr = str.Split(' ');
    string result = "";
    for(int i = arr.Length - 1; i >= 0; i--)
    {
        result += arr[i];
        result += " ";
    }
    result.Trim();
    return result;
}