// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите целое трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int finalDigit = RemoveTwoDigit(num);
// if(num > 99 && num < 1000)
// {
//         Console.WriteLine(finalDigit);
// }
// else
// {
//     Console.WriteLine("Некорректное число");
// }
Console.WriteLine((num > 99 && num < 1000) ? finalDigit : "Некорректое число");

int RemoveTwoDigit(int number)
{
    int secondDigit = number / 10 % 10;
    return secondDigit;
}