// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
double[] GetAverageElementInRow(int[,] matrix)
{

    double[] array = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double average = default;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            average += matrix[i, j];
        }
        array[i] = Math.Round(average / matrix.GetLength(1), 1);
    }
    return array;
}
int RowWithMinSum(double[] array)
{
    int i = 0;
    int indexMin = i + 1;
    double min = array[i];
    while (i < array.Length - 1)
    {
        if (min > array[i + 1])
        {
            min = array[i + 1];
            indexMin = i + 2;
            i++;
        }
        else i++;
    }
    return indexMin;
}

int[,] matrix = CreateMatrixRndInt(5, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
double[] averageElementInRow = GetAverageElementInRow(matrix);
int index = RowWithMinSum(averageElementInRow);
Console.WriteLine();
Console.WriteLine($"{index} строка с наименьшей суммой элементов");