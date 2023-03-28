// Задача 57: Составить частотный словарь 
// элементов двумерного массива. Частотный 
// словарь содержит информацию о том, сколько 
// раз встречается элемент входных данных.


int [,] CreateArray()
{
  int m = new Random().Next(1, 5);
  int n = new Random().Next(1, 5);
  int [,] matrix = new int [m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
    }
  
  }
  return matrix;
}

int [,] PrintArray(int [,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
            Console.Write(matrix[i, j] + "\t");
    }
  Console.WriteLine();
  }
  return matrix;
}


int [] Array(int [,] matrix)
{
  int k =0;
  int [] newArray = new int [matrix.GetLength(0)*matrix.GetLength(1)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
     for (int j = 0; j < matrix.GetLength(1); j++)
    {
      newArray[k]= matrix [i,j];
      k++;
     }
  }
  return newArray;
}


int [] SortArray(int [] newArray)
{
    for (int i = 0; i < newArray.Length - 1; i++)
{
    int minPosition = i;
    for (int j = i + 1; j < newArray.Length; j++)
    {
        if (newArray[j] < newArray [minPosition])
        {
            minPosition = j;
        }
    }
    int temp = newArray[i];
    newArray[i] = newArray[minPosition];
    newArray[minPosition] = temp;
}
return newArray;
}

int [,] matrix = CreateArray();
PrintArray (matrix);
Console.WriteLine();
int [] newArray = Array(matrix);
Console.WriteLine(String.Join(", ", newArray));
SortArray(newArray);
Console.WriteLine(String.Join(", ", newArray));

int el = newArray[0];
int count = 1;
for (int i = 1; i < newArray.Length; i++)
{
    if (el == newArray[i])
    {
      count ++;
    }
    else
    {
      Console.WriteLine($"Число2 {el} встречается в массиве {count} раз");
      count = 1;
      el = newArray[i];
    }
}
Console.WriteLine($"Число {el} встречается в массиве {count} раз");




