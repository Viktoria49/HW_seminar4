// Задача 27: Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int NumberDigit(int num)
{
    int sum = 0;
    if (num == 0) return 1;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
int result = NumberDigit(number);
Console.WriteLine($"Сумма цифр в числе {number}: {result}");