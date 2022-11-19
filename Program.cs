/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */
/* 
 double[,] Array2dGenerate()
{
    Console.Write("Input numbers of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of column: ");
        int colums = Convert.ToInt32(Console.ReadLine());
     Console.Write("Input min value: ");
        int minValue = Convert.ToInt32(Console.ReadLine());
     Console.Write("Input max value: ");
        int maxValue = Convert.ToInt32(Console.ReadLine()); 

   double[,] createArray = new double[rows,colums];
      

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        // createArray[i,j] = Convert.ToDouble(new Random().Next(maxValue,maxValue)) / 10; <- костыль не для вещественного если следовать логики об вещественных числах ???
        createArray[i,j] = Math.Round(Convert.ToDouble(new Random().NextDouble() * (maxValue - (minValue)) + (minValue)), 2);
    }
}
    return createArray;
}

void Show2DArray (double[,] InputArray)
{
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            Console.Write(InputArray[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] OutArray = Array2dGenerate();
Show2DArray(OutArray);  */

/* Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */

   /*  Console.Write("input rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input colum: ");
        int colum = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,colum];

void Create2dArray(int[,] array2DCreate)
{
    Console.WriteLine("input min Value: ");
        int MinValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input max Value: ");
        int MaxValue = Convert.ToInt32(Console.ReadLine());

           for (int i = 0; i < array2DCreate.GetLength(0); i++)
        {
            for (int j = 0; j < array2DCreate.GetLength(1); j++)
            {
                array[i,j] = new Random().Next(MinValue,MaxValue);
            }
        }
}

void PrintArray(int[,] arrayOutput)
{
    for (int i = 0; i < arrayOutput.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOutput.GetLength(1); j++)
        {
         Console.Write(arrayOutput[i,j] + " ");   
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindArray(int[,] arrayFind)
{
Console.Write("Input rows element: ");
    int RowsPos = Convert.ToInt32(Console.ReadLine());
Console.Write("Input column element: ");
    int ColumnPos = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine();

        if (RowsPos <  arrayFind.GetLength(0) && ColumnPos < arrayFind.GetLength(1)) Console.WriteLine("Elements ==> " + arrayFind[RowsPos,ColumnPos]);
        else Console.WriteLine($"{RowsPos},{ColumnPos} - такого числа нету в массива.");
}

    Create2dArray(array); 
    PrintArray(array); 
    FindArray(array);
 */
    

    /* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


    Console.Write("input rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input colum: ");
        int colum = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,colum];

void createArray(int[,] arrayCreate)
{
    for (int i = 0; i < arrayCreate.GetLength(0); i++)
    {
        for (int j = 0; j < arrayCreate.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,] arrayOutput)
{
    for (int i = 0; i < arrayOutput.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOutput.GetLength(1); j++)
        {
         Console.Write(arrayOutput[i,j] + " ");   
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void AverageArray(int[,] arrayAvg)
{
for (int i = 0; i < arrayAvg.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arrayAvg.GetLength(0); j++)
        {
         sum += arrayAvg[j,i];   
        }
          Console.Write($"{Math.Round( sum / arrayAvg.GetLength(0),2)} ");
    }
}

createArray(array);

PrintArray(array);

AverageArray(array);


