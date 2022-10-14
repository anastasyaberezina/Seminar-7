// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Мне кажется, все правильно делаю, но не работает.


int rows = new Random().Next(5, 5);
int columns = new Random().Next(5, 5);

int[,] array = GetArray(rows, columns, 0, 9);//Заполнили массив
PrintArray(array);//показали его

Console.WriteLine("Введите позицию элемента ");
int position1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите позицию элемента ");
int position2 = int.Parse(Console.ReadLine()!);

//int arrayposition = array[position1,position2];//Заданный элемент

int element = ElementArray(array);
//Console.WriteLine(element);

int ElementArray(int[,] arra, int row, int column, int pos1, int pos2)
{ 
    int[,] result = new int[row, column];//Назначили пустому массиву наш массив
    int position = 0; //Обозначили искомый элемент и присвоили значения
    for(int i=0; i<row; i++)
    {
        for(int j=0; j<column; j++)
        {
            if((i==pos1)&&(j==pos2))
            {
              position=result[i,j]; //Присвоили значения одного элемента другому
            }
            else
            {
                Console.WriteLine("Такой элемент отсутствует в массиве");
            }
             return position;
        }
    }
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