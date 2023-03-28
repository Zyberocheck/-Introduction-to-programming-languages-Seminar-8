// Задача 58: Задайте две матрицы. Напишите 
// программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int[,] CreateArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
        Console.WriteLine();
    }
    return array;
}


int[,] PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

void MultiMatrix(int[,] matrixA,int[,] matrixB,int[,] matrixScore)
{    
    for (int i = 0; i < matrixScore.GetLength(0); i++)
    {
        for (int j = 0; j < matrixScore.GetLength(1); j++)
        {
            int sumMultiMatrix = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
            sumMultiMatrix+= matrixA[i, k] * matrixB[k, j];
            }
            matrixScore[i,j]=sumMultiMatrix;
        }
        Console.WriteLine();
    }
}


int[,] matrixA = new int[2, 2];
CreateArray(matrixA);
Console.WriteLine("Первая матрица: ");
PrintArray(matrixA);
int[,] matrixB = new int[2, 2];
CreateArray(matrixB);
Console.WriteLine("Вторая матрица: ");
PrintArray(matrixB);

int[,] matrixScore = new int[2, 2];

MultiMatrix(matrixA, matrixB, matrixScore);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(matrixScore);




