//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
Console.WriteLine("Введите X");
int xValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y");
int yValue = Convert.ToInt32(Console.ReadLine());
if (xValue > 0 && yValue > 0)
{
    Console.WriteLine("1");
}
else if (xValue > 0 && yValue < 0)
{
    Console.WriteLine("2");
}
else if (xValue < 0 && yValue < 0)
{
    Console.WriteLine("3");
}
else if (xValue < 0 && yValue > 0)
{
    Console.WriteLine("4");
}
else
{
    Console.WriteLine("Некорректные данные!");
}