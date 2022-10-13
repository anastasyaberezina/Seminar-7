// 


int rows = new Random().Next(3, 11);
int columns = new Random().Next(4, 11);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int[,] array2 = NewGetArray(array);
PrintArray(array2);

int[,] NewGetArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            if((i%2==0)&&(j%2==0))
            {
            array[i,j]=array[i,j]*array[i,j];
            }
        }
    }
    return array;
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
