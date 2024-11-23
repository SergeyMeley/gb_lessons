// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива.
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28

//double[] arr = new double[] { 2.2, 0.4, 9.11, 7.2, 78.98 };
double[] arr = new double[] { 1.22, 4.5, 3.33 };
double min = arr[0];
double max = arr[0];
foreach(double item in  arr)
{
    if(item < min)
    {
        min = item;
    }
    else if(item > max)
    {
        max = item;
    }
}
double delta = max - min;
Console.WriteLine(delta);