//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

/*int[,] Create2DRandArray(int minValue, int maxValue, int rows, int columns)
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
}
Console.WriteLine("Input the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the minimum value of the element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the maximum value of the element: ");
int max = Convert.ToInt32(Console.ReadLine());
Print2DArray(Create2DRandArray(min, max, rows, columns));*/



//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.

/*int[,] Create2DRandArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = i + j;
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
}
Console.WriteLine("Input the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Print2DArray(Create2DRandArray(rows, columns));*/



//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
//Например, изначально массив выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:

//1 4 7 2
//5 **81  ** 2 **9**
//8 4 2 4

/*int[,] Create2DRandArray(int minValue, int maxValue, int rows, int columns)
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
int[,]ReplaceElement(int[,]array)
{
   for(int i = 1; i < array.GetLength(0); i++)
    {    
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                array[i,j] *= array[i,j];
            }
        }
    }
    return array;
}
Console.WriteLine("Input the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the minimum value of the element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the maximum value of the element: ");
int max = Convert.ToInt32(Console.ReadLine());
Print2DArray(Create2DRandArray(min, max, rows, columns));
Print2DArray(ReplaceElement(Create2DRandArray(min, max, rows, columns)));*/



//Задача 4. адайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Например, задан массив:

/*int[,] Create2DRandArray(int minValue, int maxValue, int rows, int columns)
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
}
int[,] SumElementsMainDiagonal(int [,] array)
{ 
    int sum = 0; // результирующая сумма
    for (int i = 0; i < array.GetLength(0); i++) // задание строк
    {
        for (int j = 0; j < array.GetLength(1); j++) // задание столбцов
        {
            if (i == j)
            {
                sum = sum + array[i,j];
            }           
        }
    }
    Console.WriteLine($"The sum of the elements of the main diagonal {sum}.");
    return array;
}
Console.WriteLine("Input the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the minimum value of the element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the maximum value of the element: ");
int max = Convert.ToInt32(Console.ReadLine());
Print2DArray(SumElementsMainDiagonal(Create2DRandArray(min, max, rows, columns)));*/



//Задача. Напишите программу, которая на вход принимает целое число,
//и возвращает количество числе в массиве или же указание, что такого числа нет.

int[,] Create2DRandArray(int minValue, int maxValue, int rows, int columns)
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
void CheckingElement(int number, int[,]array)
{
    int count = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == number) count += 1;    
        }   
    }
    if(count > 0) Console.WriteLine($"The number {number} enters the array {count} times.");
    else Console.WriteLine($"The number {number} is not in the array."); 
}
Console.WriteLine("Input the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the minimum value of the element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the maximum value of the element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandArray(min, max, rows, columns);
Print2DArray(myArray);
Console.WriteLine("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());
CheckingElement(number, myArray);