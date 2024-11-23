// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.
// [344 452 341 125] => 2

int[] arr = new int [10];
Random random = new Random();
for(int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(100 , 1000);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(count);
