// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Та же самая ошибка, не понимаю что не так.

int rows = new Random().Next(5, 5); //Назначили кол-во строк и элементов в них
int columns = new Random().Next(5, 5); //Назначили кол-во столбцов и элементов в них

int[,] array = GetArray(rows, columns, 0, 20); //Применили метод к новому пустому массиву, тем самым заполнив его случ числами от 0 до 20
PrintArray(array);
Console.WriteLine(); //Отступ для красоты 

int Res = Arif(array); //Новый массив с результатом вычислений
PrintArray(Res); 

int Arif(int[,] arra) //Метод возвращает , принимает массив как аргумент
{
    int arifm = 0; //Переменная искомое
    for(int i=0; i<arra.GetLength(0); i++)
    {
        for(int j=0; j<arra.GetLength(1); j++)
        {
            if(i==0)
              {
                arifm+=array[i,j]/j;//Вычисляем среднее арифметическое
              }
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
