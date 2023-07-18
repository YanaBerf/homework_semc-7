/*Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows= int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns= int.Parse(Console.ReadLine());

double[,] array = GetArray(rows, columns);
PrintArray(array);

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*100;
        
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}






/*Console.Write(«Введите размерность m массива: «);
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(«Введите размерность n массива: «);
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m,n];

void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
Console.WriteLine();
for (j = 0; j < n; j++)
{
randomArray[i,j] = rand.NextDouble();
Console.Write($»{randomArray[i,j]:F2} «);
}

}

}

mas(m,n);*/

/*//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами
using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

double[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*(max-min);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]:f1} ");
        }
        WriteLine();
    }
}*/