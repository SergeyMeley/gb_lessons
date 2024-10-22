//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.WriteLine("Введите число от 10 до 99: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 10 && num <= 99)
{
    int firstNum = num / 10;
    int secondNum = num % 10;
    int result;
    if (firstNum > secondNum)
    {
        result = firstNum;
    }
    else
    {
        result = secondNum;
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Введено некорректное значение!");
}

