// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите коэффициент b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

void CrossPoint(double b1, double k1, double b2, double k2)
{
    if (b1 == b2 && k1 == k2) Console.WriteLine("Прямые совпадают");
    else
    if (k1 == k2) Console.WriteLine("Заданные прямые не пересекаются");
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = k2 * x + b2;
        Console.WriteLine($"Точка пересечения прямых ({x}, {y})");
    }
}
CrossPoint(b1, k1, b2, k2);

