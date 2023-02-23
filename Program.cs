/*Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1, 7] -> такого числа в массиве нет*/


using System;
using static System.Console;


Write("Введите номер строки ");
int rows = int.Parse(ReadLine());

Write("Введите номер столбца ");
int columns = int.Parse(ReadLine());

Clear();

PrintArray (GetArray(5, 5, 0, 10), rows, columns);


int [,] GetArray(int m, int n, int min, int max)
{
    int [,] result = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max+1);
        }

    }
    return result;
}


void PrintArray(int[,] array, int x, int y)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    } 
    
    
    WriteLine();
    if (x<array.GetLength(0) && y<array.GetLength(1))
    WriteLine($"{array[x, y]} ");
    else WriteLine("Такого числа нет");
}