// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int rows = new Random().Next(5, 5);
int columns = new Random().Next(5, 5);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int[,] Res = Arif(array);
PrintArray(Res);

int[,] Arif(int[,] arra, int row, int column)
{
    int arifm = 0;
    for(int i=0; i<arra.GetLength(0); i++)
    {
        for(int j=0; j<arra.GetLength(1); j++)
        {
              arifm+=array[i,j];
        }
    }
    return arifm;
}

int[,] GetArray(int rows, int columns, int minValue, int maxValue) //Функция заполнения массива.
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

void PrintArray (int[,] array) //Функция выведения массива.
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
