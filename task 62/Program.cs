// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
};

int rows = 4;
int columns = 4;
int[,] matrix = new int[rows, columns];

void FillMatrixSpiral(int[,] matrix)
{
    int count = 1;
    for (int i = 0; i < rows; i++)
    {
        for (int j = i; j < rows - i; j++) matrix[i, j] = count++;
        for (int k = i + 1; k < columns - i; k++) matrix[k, columns - i - 1] = count++;
        for (int j = rows - 2 - i; j >= i; j--) matrix[rows - 1 - i, j] = count++;
        for (int k = columns - 2 - i; k > i; k--) matrix[k, i] = count++;
    }
};

FillMatrixSpiral(matrix);
PrintMatrix(matrix);