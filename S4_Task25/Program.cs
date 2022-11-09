// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponent(int number1, int number2)
{
    if (number2 == 0) return 1;
    int exponent = number1;
    for (int i = 1; i < Math.Abs(number2); i++)
    {
        exponent = exponent * number1;
    }
    return exponent;
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());


int exponent = Exponent(num1, num2);
Console.WriteLine((num2 < 0) ? $" 1 / {exponent}" : exponent);