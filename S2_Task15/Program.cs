// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Weekend(num);
void Weekend(int number)
{
    switch (number)
    {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            Console.WriteLine("Нет");
            break;
        case 6:
        case 7:
            Console.WriteLine("Да");
            break;
        default:
            Console.WriteLine("Такого дня недели не существует");
            break;
    }
}