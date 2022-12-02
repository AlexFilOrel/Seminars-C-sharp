//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/*double[,] Create2DRandArray(int rows, int columns)
{
    double[,] newArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().NextDouble() * 60 - 30;
        }
        return newArray;
}
void Print2DArray(double[,]array)
{
    Console.WriteLine("The received array -> ");
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}
Console.WriteLine("Input the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] myArray = Create2DRandArray(rows, columns);
Print2DArray(myArray);*/



//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

/*int[,] Create2DRandArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue,maxValue + 1);
        }
        return newArray;
}
void Print2DArray(int[,]array)
{
    Console.WriteLine("The received array -> ");
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void ReturnElement(int pos1, int pos2, int[,]array)
{
    if(pos1 < array.GetLength(0) && pos2 < array.GetLength(1))
    {
        Console.WriteLine($"The number {array[pos1, pos2]} is in the array.");
    }
    else Console.WriteLine($"Positions {pos1}, {pos2} are not in the array.");
}
Console.WriteLine("Input the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the minimum value of the element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the maximum value of the element: ");
int max = Convert.ToInt32(Console.ReadLine());
int [,]myArray = Create2DRandArray(rows, columns, min, max);
Print2DArray(myArray);
Console.WriteLine("Input the position of the (i) element: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the position of the (j) element: ");
int pos2 = Convert.ToInt32(Console.ReadLine());
ReturnElement(pos1, pos2, myArray);*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*double[,] Create2DRandArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue,maxValue + 1);
        }
        return newArray;
}
void Print2DArray(double[,]array)
{
    Console.WriteLine("The received array -> ");
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " | ");
        }
    Console.WriteLine();
    }
}
void MedianSumColumns(double[,]array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++) sum += array[i,j];
        Console.Write($"{ sum / array.GetLength(0)} / ");
    }
    Console.WriteLine();
}
Console.WriteLine("Input the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the minimum value of the element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the maximum value of the element: ");
int max = Convert.ToInt32(Console.ReadLine());
double [,]myArray = Create2DRandArray(rows, columns, min, max);
Print2DArray(myArray);
Console.WriteLine("=========================");
MedianSumColumns(myArray);*/