// Задача 56: Задайте прямоугольный двумерный 
// массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// int InPutNumber(string message)
// {
//     Console.WriteLine(message);
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }


// int m = InPutNumber("Введите количество строк: ");
// int n = InPutNumber("Введите количество столбцов: ");


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


int[,] PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}


void SumString(int[,] matrix)
{
    int minsumString = 0;
    int sumString = 0;
    int numMinString =0;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minsumString += matrix[0, i];
    } 

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sumString+= matrix[i,j];
            }    
                if(sumString<minsumString)
                {
                    minsumString=sumString;
                    numMinString = i;
                }
                sumString=0;
        }
    Console.WriteLine();
    Console.Write($"{numMinString + 1} строка с минимальной суммой");
}


int[,] matrix = new int[4, 4];
CreateArray(matrix);
PrintArray(matrix);
SumString(matrix);






