// Задача 53: Задайте двумерный массив.
//  Напишите программу,
// которая поменяет местами первую 
// и последнюю строку массива.

System.Console.WriteLine("Введите количество столбцов массива:");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void ExchangeArray(int[,] array)
{
    int tmp;
    int LastIndex = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        tmp = array[LastIndex, i];
        array[LastIndex, i] = array[0, i];
        array[0, i] = tmp;
    }
}

void OutputArray(int[,] array, string str)
{
    System.Console.WriteLine($"{str}:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int [,] array = CreateArray(n ,m);
System.Console.WriteLine();
OutputArray(array, "Исходный массив");
ExchangeArray(array);
OutputArray(array, "Конечный массив");


