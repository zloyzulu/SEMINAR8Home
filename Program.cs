// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

double[,] CreateRandom2dArray(int m, int n, int min, int max)
{
    double[,] array = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max +1);
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] array = CreateRandom2dArray(rows, cols, 0, 50);

Show2dArray(array);
Console.WriteLine();

void Create2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double temp = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1) -1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    Show2dArray(array);
}

Create2dArray(array);
*/


// 56. Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*

void CreateRandom2dArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"| {array[i,j]}");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[rows,cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
    array[i,j]  = new Random().Next(-11,11);

    }
}

int Create2dArray = 0;
int minsum = 100000;
for (int i = 0; i < rows; i++)
{
  int sum = 0;
  
  for (int j = 0; j < cols; j++)
  {
    sum = sum + array[i,j];
  }

if (sum < minsum)
{ minsum = sum;
  Create2dArray = i+1; 
  }

}
CreateRandom2dArray(array);
Console.WriteLine();
Console.WriteLine($"{Create2dArray}-я строка с наименьшей суммой");

*/


// Задача 62. Программа, которая заполняет спирально массив 4 на 4.

/*
int n = 4;
int[,] array = new int [n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}

void CreateRandom2dArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
CreateRandom2dArray(array);

*/
