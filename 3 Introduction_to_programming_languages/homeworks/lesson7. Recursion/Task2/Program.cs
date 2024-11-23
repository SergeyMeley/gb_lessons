// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

Console.Write(Ackerman(3, 2));

int Ackerman(int n, int m)
{
    if(n == 0)
    {
        return m + 1;
    }
    else if(m == 0)
    {
        return Ackerman(n - 1, 1);
    }
    else
    {
        return Ackerman(n - 1, Ackerman(n, m - 1));
    }
}
