// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int numM, int numN)
{
    if (numM == numN) return numM;
    return numM + SumNumbers(numM > numN ? numM - 1 : numM + 1, numN);
}

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM > 0 && numberN > 0)
{
    int sumNumbers = SumNumbers(numberM, numberN);
    Console.WriteLine($"Сумма чисел в промежутке от {numberM} до {numberN} = {sumNumbers}");
}
else if (numberM < 1) Console.WriteLine("Введено некорректное число M");
else Console.WriteLine("Введено некорректное число N");