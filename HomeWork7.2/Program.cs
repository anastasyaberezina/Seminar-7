// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.WriteLine("Введите позицию элемента ");
int position = int.Parse(Console.ReadLine()!);

int rows = new Random().Next(5, 5);
int columns = new Random().Next(5, 5);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
int element = ElementValue(array);
Console.WriteLine(element);

int ElementValue(int[,] array, int pos)
{
    int pos1=pos/10;
    int pos2=pos%10;
    int result = array[pos1,pos2];

    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            if((i==pos1&&j==pos2))
            {
              result=array[i,j];
            }
            else
            {
                Console.WriteLine("Такой элемент отсутствует в массиве");
            }
        }
    }
    return result;
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