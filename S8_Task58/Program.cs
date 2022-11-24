// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    // int[,] replaceMatrix = ReplaceRowsColumns(matrix2);
    int[,] matr = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matr[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matr;
}

int[,] newMatrix1 = CreateMatrixRndInt(5, 4, 1, 10);
int[,] newMatrix2 = CreateMatrixRndInt(4, 6, 1, 10);
PrintMatrix(newMatrix1);
Console.WriteLine();
PrintMatrix(newMatrix2);
Console.WriteLine();
if (newMatrix1.GetLength(1) == newMatrix2.GetLength(0))
{
    int[,] matrixProduct = MatrixProduct(newMatrix1, newMatrix2);
    PrintMatrix(matrixProduct);
}
else Console.WriteLine("Произведение данных матриц невозможно");