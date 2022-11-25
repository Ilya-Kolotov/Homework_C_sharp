// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAkkerman(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM > 0 && numN == 0) return FunctionAkkerman(numM - 1, 1);
    return FunctionAkkerman(numM - 1, FunctionAkkerman(numM, numN - 1));
}

Console.Write("Введите неотрицательное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM >= 0 && numberN >= 0)
{
    int sumNumbers = FunctionAkkerman(numberM, numberN);
    Console.WriteLine($"A({numberM}, {numberN}) = {sumNumbers}");
}
else if (numberM < 0) Console.WriteLine("Введено некорректное число M");
else Console.WriteLine("Введено некорректное число N");