//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*int[] CreateRandArray(int size)
{
    int[]newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100, 1000);
    }
    return newArray;
}
void PrintArray(int[] array)
{
    Console.Write("The received array -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void FindEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }
    Console.WriteLine($"The number of even numbers in array is {count}.");
}
Console.WriteLine("Input size ");
int size = Convert.ToInt32(Console.ReadLine());
int[] MyArray = CreateRandArray(size);
PrintArray(MyArray);
FindEvenNumbers(MyArray);*/



//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*int[] CreateRandArray(int size)
{
    int[]newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(1, 100);
    }
    return newArray;
}
void PrintArray(int[] array)
{
    Console.Write("The received array -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void FindNumbersOddIndex(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        count += array[i];
    }
    Console.WriteLine($"The sum of numbers with an odd array index is {count}.");
}
Console.WriteLine("Input size ");
int size = Convert.ToInt32(Console.ReadLine());
int[] MyArray = CreateRandArray(size);
PrintArray(MyArray);
FindNumbersOddIndex(MyArray);*/



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

/*nt[] CreateRandArray(int size)
{
    int[]newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(-100, 101);
    }
    return newArray;
}
void PrintArray(int[] array)
{
    Console.Write("The received array -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int FindMaxMinDifference(int[] array)
{
    int numMax = 0;
    int numMin = 0;
    int difference = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(numMax < array[i]) numMax = array[i];
        for (int j = i; j < array.Length; j++)
        {
            if(numMin > array[i]) numMin = array[i];
        }
    }
    difference = numMax - numMin;
    return difference;
}
Console.WriteLine("Input size ");
int size = Convert.ToInt32(Console.ReadLine());
int[] MyArray = CreateRandArray(size);
PrintArray(MyArray);
int result = FindMaxMinDifference(MyArray);
Console.WriteLine($"The difference between the maximum and minimum array element is {result}.");*/