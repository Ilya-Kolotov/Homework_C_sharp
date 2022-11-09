// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int number)
{
    int sumDigits = 0;
    while (Math.Abs(number) > 0)
    {
        sumDigits = sumDigits + number % 10;
        number /= 10;
    }
    return Math.Abs(sumDigits);
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


int sumDigits = SumDigits(num);
Console.WriteLine($"Сумма цифр в числе {num} = {sumDigits}");