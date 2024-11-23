// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца
// 4 3 1   =>  2 6
// 2 6 9       4 6
// 4 6 2

int[,] inputArray = 
{
    { 4, 3, 1 },
    { 2, 6, 9 },
    { 4, 6, 2 },
};

int valueMin = inputArray[0,0];
int xMin = 0;
int yMin = 0;
FindMinimum(inputArray);

void FindMinimum(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < valueMin)
            {
                valueMin = array[i,j];
                xMin = i;
                yMin = j;
            }
        }
    }
    Console.WriteLine(valueMin);
    Console.WriteLine(xMin);
    Console.WriteLine(yMin);
}