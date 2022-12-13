// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

using System;
using static System.Console;

Clear();

Write("Введите номер позиции строки массива: ");
int numberRow =int.Parse(ReadLine());

Write("Введите номер позиции столбца массива: ");
int numberColumn =int.Parse(ReadLine());

int[,] array = GetArray(4, 4, 0, 9);
PrintArray(array);
GetValueElement(array, numberRow, numberColumn);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i,j]} ");
        }
        WriteLine();
    }
}
void GetValueElement(int[,] array, int numberRow, int numberColumn)
{
    if(numberRow > array.GetLength(0) || numberRow <=0 || numberColumn > array.GetLength(1) || numberColumn <= 0)
    {
        WriteLine($"({numberRow}, {numberColumn}) -> Такого элемента нет");
    } else 
    {
        WriteLine($"Значение элемента ({numberRow}, {numberColumn}) -> {array[numberRow-1, numberColumn-1]}");
    }
}