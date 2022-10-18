// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100 && num > -100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int finalDigit = ThirdDigit(num);
    Console.WriteLine(finalDigit >= 0 ? finalDigit : finalDigit * -1);
}

int ThirdDigit (int number)
{
    while(number > 999 || number < -999)
    {
        number = number / 10;
    }
    number = number % 10;
    return number;
}