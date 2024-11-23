// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.
// “aBcD1ef!-” => “abcd1ef!-”

Console.WriteLine("Введите строку: ");
string inputString = Console.ReadLine();
Console.WriteLine(GetLowerString(inputString));

string GetLowerString(string str)
{
    string result = "";
    for(int i = 0; i < str.Length; i++)
    {
        if(char.IsLower(str[i]))
        {
            result += str[i];
        }
        else
        {
            result += char.ToLower(str[i]);
        }
    }
    return result;
}
