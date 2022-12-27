//...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillMatrix(int[,,] matrix)
{
    int[,,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1), matrix.GetLength(2)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                newMatrix[i, j, z] = new Random().Next(1, 100);
                if(newMatrix[i,j,z] == newMatrix[i,j,z])
                {
                    newMatrix[i,j,z] = new Random().Next(1, 100);
                }
                Console.Write(newMatrix[i, j, z] + $"({i},{j},{z})" + " ");
            }
            Console.WriteLine();
        }
    }
    return newMatrix;
}

int[,,] matrix = new int[2, 2, 2];
FillMatrix(matrix);