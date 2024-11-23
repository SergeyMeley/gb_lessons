// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]

string value = "";
while (true)
{
    Console.Write("Введите целое число или символ 'q': ");
    value = Console.ReadLine();
    if (!CheckConditionInput(value))
    {
        Console.WriteLine("Введено некорректное значение, повторите попытку!");
    }
    else
    {
        if (CheckConditionQ(value) | CheckConditionEven(value))
        {
            Console.WriteLine("СТОП");
            break;
        }
    }
}
bool CheckConditionInput(string inputValue)
{
    return inputValue == "q" || int.TryParse(inputValue, out int val);
}
bool CheckConditionQ(string valueInput)
{
    return valueInput == "q";
}
bool CheckConditionEven(string valueInput)
{
    int.TryParse(valueInput, out int val);
    bool condition = false;
    int sum = 0;
    int length = 0;
    while (val != 0)
    {
        sum += val % 10;
        val /= 10;
        length++;
    }
    return sum % 2 == 0;
}
