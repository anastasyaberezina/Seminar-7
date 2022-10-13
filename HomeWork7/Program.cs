﻿// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int m = new Random().Next(7, 7);
int n = new Random().Next(7, 7);

int[,] array = GetArray(m, n, -99, 99);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] result = new int[m, n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j]=new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
}


void PrintArray (int[,] array) 
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}