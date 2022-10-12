// Задать двум массив размена m на n. Каждый элемент находится по формуле Amn=m+n. Выведите полученный массив.

Console.WriteLine("Количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);


int[,] array = GetArray(rows, columns);
PrintArray(array);



int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j]=i+j;
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