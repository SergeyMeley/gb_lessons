﻿// Задача 1: Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90].
// массив [10 21 14 93 23] => 2

int[] arr = new int[10]{10, 21, 14, 93, 23, 10, 21, 14, 93, 23};
int count = 0;
foreach(int item in arr)
{
    if (item >= 20 &&  item <= 90)
    {
        count++;
    }
}
Console.WriteLine(count);
