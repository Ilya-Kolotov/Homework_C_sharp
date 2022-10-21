// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число N:");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1)
{
    Console.WriteLine("Недопустимое число");
}
else
{
    Cube(num);
}

void Cube(int number)
{

    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"{i, 4} | {i * i * i, -4}");
    }
}