// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

Console.WriteLine("Введите строку:");
string inputString = Console.ReadLine();
bool result = IsPolindrome(inputString);
if(result)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

bool IsPolindrome(string str)
{
    bool result = true;
    for(int i = 0; i < str.Length / 2; i++)
    {
        if(char.ToLower(str[i]) != char.ToLower(str[str.Length - 1 - i]))
        {
            result = false;
        }
    }
    return result;
}