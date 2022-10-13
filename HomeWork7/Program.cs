// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int rows = new Random().Next(7, 7);
int columns = new Random().Next(7, 7);

int[,] array = GetArray(rows, columns, -99, 99);
PrintArray(array);

int[,] GetArray(int rows, int columns, int minValue, int maxValue) 
{
    int[,] result = new int[rows, columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
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