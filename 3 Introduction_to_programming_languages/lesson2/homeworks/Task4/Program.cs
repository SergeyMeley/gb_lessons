//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    string result = "";
int value = num;
int digits = 0;
while (value != 0)
{
    value /= 10;
    digits++;
}
for (int i = digits; i > 0; i--)
{
    int coef = 1;
    for(int j = 1; j < i; j++)
    {
        coef *= 10;
    }
    result += Convert.ToString(num % (coef * 10) / (coef));
    if (i > 1)
    {
        result += ",";
    }
}
Console.WriteLine(result);
}
else
{
    Console.WriteLine("Введено некорректное число!");
}