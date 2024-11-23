// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] array = { 1, 2, 5, 0, 10, 34 };
WriteReverceArray(array, 0);

void WriteReverceArray(int[] arr, int index)
{
    if(index == arr.Length)
    {
        return;
    }
    WriteReverceArray(arr, index + 1);
    Console.Write($"{arr[index]} ");
}