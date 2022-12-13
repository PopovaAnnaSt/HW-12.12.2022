// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

double[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);

Double[,] GetArray(int m, int n, Double minValue, Double maxValue)
{
    Double[,] result = new Double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * 8.0 - 2.0;;
        }
    }
    return result;
}

void PrintArray(Double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]:f2} ");
        }
        WriteLine();
    }
}