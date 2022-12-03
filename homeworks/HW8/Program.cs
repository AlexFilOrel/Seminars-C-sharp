//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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
void SelectionSort2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int minPosition = j;
            for(int jtemp = j + 1; jtemp < array.GetLength(1); jtemp++)
            {
                if(array[i,jtemp] > array[i,minPosition]) minPosition = jtemp;
            }
            int temp = array[i,j];
            array[i,j] = array[i,minPosition];
            array[i,minPosition] = temp;
        }
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
int [,]myArray = Create2DRandArray(rows, columns, min, max);
Print2DArray(myArray);
SelectionSort2DArray(myArray);
Print2DArray(myArray);*/



//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
void SmallestSumInRow(int[,] array)
{
    int sumRow = 0;
    int minRow = 0;
    int posMinRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minRow += array[0, j];
    }
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        if (sumRow < minRow)
        {
            minRow = sumRow;
            posMinRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"The row with the smallest sum of elements: {posMinRow + 1} row.");
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
int [,]myArray = Create2DRandArray(rows, columns, min, max);
Print2DArray(myArray);
SmallestSumInRow(myArray);*/



//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

/*int[,] CreateFirstMatrix(int rowsFM, int columnsFM, int minValue, int maxValue)
{
    int[,] firstMatrix = new int[rowsFM, columnsFM];
    for (int i = 0; i < rowsFM; i++)
        for (int j = 0; j < columnsFM; j++)
        {
            firstMatrix[i,j] = new Random().Next(minValue,maxValue + 1);
        }
        return firstMatrix;
}
int[,] CreateSecondMatrix(int rowsSM, int columnsSM, int minValue, int maxValue)
{
    int[,] secondMatrix = new int[rowsSM, columnsSM];
    for (int i = 0; i < rowsSM; i++)
        for (int j = 0; j < columnsSM; j++)
        {
            secondMatrix[i,j] = new Random().Next(minValue,maxValue + 1);
        }
        return secondMatrix;
}
void Print2DArray(int[,]array)
{
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
int[,] FindProductMatrices (int[,]matrixFirst, int[,]matrixSecond, int rowsFM, int columnsSM)
{
    int[,] resultMatrix = new int[rowsFM, columnsSM];
    if(matrixFirst.GetLength(0) != matrixSecond.GetLength(1))
    {
        Console.WriteLine("Matrices are incompatible!!!");
    }
    else
    {
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                int product = 0;
                for (int k = 0; k < matrixFirst.GetLength(1); k++)
                {
                    product += matrixFirst[i,k] * matrixSecond[k,j];
                }
                resultMatrix[i,j] = product;
            }
        }
    }
    return resultMatrix;
}
Console.WriteLine("Input the number of rows of the first matrix: ");
int rowsFM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns of the first matrix: ");
int columnsFM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of rows of the second matrix: ");
int rowsSM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns of the second matrix: ");
int columnsSM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the minimum value of the element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the maximum value of the element: ");
int max = Convert.ToInt32(Console.ReadLine());
int [,]matrixFirst = CreateFirstMatrix(rowsFM, columnsFM, min, max);
int [,]matrixSecond = CreateSecondMatrix(rowsSM, columnsSM, min, max);
Console.WriteLine($"First matrix:");
Print2DArray(matrixFirst);
Console.WriteLine($"Second matrix:");
Print2DArray(matrixSecond);
int [,]ResultMatrix = FindProductMatrices(matrixFirst, matrixSecond, rowsFM, columnsFM);
Console.WriteLine($"the product of the first and second matrix:");
Print2DArray(ResultMatrix);*/



//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

/*int[,,] Create3DRandArray(int rows, int columns, int pages)
{
    int[,,] newArray = new int[rows, columns, pages];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < pages; k++)
            {
                Random random = new Random();
                while (newArray[i, j, k] == 0)
                {
                    int num = random.Next(10,100);

                    if (IsNumberInArray(newArray, num) == false)
                    {
                        newArray[i, j, k] = num;
                    }
                }
            }
            return newArray;
}
bool IsNumberInArray(int[,,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == num) return true;
            }
        }
    }
    return false;
}
void Print3DArray(int[,,]array)
{
    Console.WriteLine("The received array -> ");
    for(int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i,j,k]}({i},{j},{k})");
            }
    Console.WriteLine();
}
Console.WriteLine("Input the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of pages: ");
int pages = Convert.ToInt32(Console.ReadLine());
Print3DArray(Create3DRandArray(rows, columns, pages));*/



//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

/*int[,] CreateSpiral2DArray(int size)
{
    int[,] spiralArray = new int[size, size];
    int firstnum = 1;
    int i = 0;
    int j = 0;

    while (firstnum <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
    {
        spiralArray[i, j] = firstnum;
        firstnum++;
        if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
        {
            j++;
        }
        else if (i < j && i + j >= spiralArray.GetLength(0) - 1)
        {
            i++;
        }
        else if (i >= j && i + j > spiralArray.GetLength(1) - 1)
        {    
            j--;
        }
        else
        {
            i--;
        }
    }
        return spiralArray;
}
void Print2DArray(int[,]array)
{
    Console.WriteLine("The received array -> ");
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("Input aize array: ");
int size = Convert.ToInt32(Console.ReadLine());
int [,]myArray = CreateSpiral2DArray(size);
Print2DArray(myArray);*/