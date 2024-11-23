 // Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат:");
WriteNumbers(firstNumber, secondNumber);

void WriteNumbers(int firstNum, int secondNum)
{
    if(firstNum < secondNum)
    {
        Console.Write($"{firstNum}, ");
        WriteNumbers(firstNum + 1, secondNum);
    }
    else if (firstNum > secondNum)
    {
        Console.Write($"{firstNum}, ");
        WriteNumbers(firstNum - 1, secondNum);
    }
    else
    {
        Console.Write($"{firstNum}");
        return;
    } 
}