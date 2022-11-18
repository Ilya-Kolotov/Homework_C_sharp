// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}
void ChangeElementInMatrix(int[,] matrix, int rows, int columns)
{

    if (rows <= matrix.GetLength(0) && columns <= matrix.GetLength(1))
    { Console.WriteLine($"Элемент в массиве = {matrix[rows - 1, columns - 1]}"); }
    else { Console.WriteLine("Такого элемента в массиве нет"); }
}
Console.WriteLine("Задайте позицию элемента");
Console.Write("Введите номер строки: ");
int row_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column_number = Convert.ToInt32(Console.ReadLine());
if (row_number > 0 && column_number > 0)
{
    int[,] matrix = CreateMatrixRndInt(7, 9, 1, 10);
    PrintMatrix(matrix);
    ChangeElementInMatrix(matrix, row_number, column_number);
}
else Console.WriteLine("Введите число больше 0");