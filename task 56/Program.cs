// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [m,n];
for(int i = 0; i < m; i++)
{
for(int j = 0; j < n; j++)

{
matrix[i,j] = new Random().Next(0,11);
Console.Write(matrix[i,j] + " ");

}
Console.WriteLine();
}
Console.WriteLine(matrix.GetLength(1));
int minPosition = Int32.MaxValue;
int index = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];
    }
     if (sum < minPosition)
    {
        minPosition = sum;
        index++;
    }
}

Console.WriteLine("строка с наименьшей суммой элементов под номером: " + (index) + ", с суммой элементов равной: " + (minPosition));
    

Console.ReadLine();