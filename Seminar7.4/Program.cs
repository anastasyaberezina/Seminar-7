// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами 0,0; 1,1 и т.д.)

int rows = new Random().Next(5, 5);
int columns = new Random().Next(5, 5);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int Sum = SumArray(array);
Console.WriteLine(Sum);

int SumArray(int[,] array)
{
    int sum = 0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            if(i==j)
            {
              sum+=array[i,j];
            }
        }
    }
    return sum;
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