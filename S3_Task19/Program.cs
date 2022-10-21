// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNum = ReversalNumber(Math.Abs(num));
if (Math.Abs(num) > 9999 && Math.Abs(num) < 100000)
{
    if (newNum == Math.Abs(num))
    {
        Console.WriteLine("Да");
    }
    else
        Console.WriteLine("Нет");
}
else
Console.WriteLine("Введено некорректное число");

int ReversalNumber(int number)
{
    int count = 0;
    int reversalNumber = 0;
    while (number / 1 > 0)
    {
        count = number % 10;
        reversalNumber = reversalNumber * 10 + count;
        number /= 10;
    }
    return reversalNumber;
}