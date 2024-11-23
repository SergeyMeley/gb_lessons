// Задача 4**(не обязательно): Дано натуральное
// число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.
// 425 => [4 2 5]
// 8741 => [8 7 4 1]
// 4 => [4]

Console.Write("Введите число от 1 до 100 000: ");
int value = Convert.ToInt32(Console.ReadLine());
if(value >= 1 && value <= 100000)
{
int length = 1;
int remainder = value / 10;
while(remainder != 0)
{
    remainder /= 10;
    length++;
}
int[] arr = new int[length];
for (int i = 0; i <= length - 1; i++)
{
    arr[i] = value % 10;
    value /= 10;
}
Console.Write("[");
for (int i = 0; i <= arr.Length - 1; i++)
{
    Console.Write($"{arr[arr.Length - 1 - i]}");
    if(i != arr.Length - 1)
    {
        Console.Write(" ");
    }
}
Console.Write("]");
}
else{
    Console.WriteLine("Указано некорректное число!");
}