//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//8 4 2 4
//5 9 2 3
//1 4 7 2

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
}
int[,] ChangeRows(int[,]array,int row1, int row2)
{
    if(row1 > array.GetLength(0) || row2 > array.GetLength(0))
    return array;
    else
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1,j];
            array[row1,j] = array[row2,j];
            array[row2,j] = temp;
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
Console.WriteLine("Input the number first row: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number second row: ");
int row2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandArray(rows,columns,min,max);
Print2DArray(myArray);
myArray = ChangeRows(myArray, row1, row2);
Console.WriteLine();
Print2DArray(myArray);*/



//Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//В итоге получается вот такой массив:
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7


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
}
int[,] ChangeIndex (int[,] array)
{
    if(array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("It is impossible to output an array");
        return array;
    }
    else
    {
        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for(int j = i + 1; j < array.GetLength(0); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
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

int[,] myArray = Create2DRandArray(rows,columns,min,max);
Print2DArray(myArray);
myArray = ChangeIndex(myArray);
Console.WriteLine();
Print2DArray(myArray);*/



//Задание 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент

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
}
int [,] NullElementArray(int[,]array)
{
    int minimali = 0;
    int minimalj = 0;
    int minimalElement = array[0,0];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < minimalElement)    
            {
                minimalElement = array[i,j];
                minimali = i; //0
                minimalj = j; //0
            }       
        }
    }
    for(int i = 0; i < array.GetLength(0); i++)
    {
        array [i,minimalj] = 0;
    }
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array [minimali,j] = 0;
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

int[,] myArray = Create2DRandArray(rows,columns,min,max);
Print2DArray(myArray);
myArray = NullElementArray(myArray);
Console.WriteLine();
Print2DArray(myArray);*/