//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

/*int[] CreateRandArray(int size, int minValue, int maxValue)
{
    int[]newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue,maxValue + 1);
    }
    return newArray;
}
void PrintArray(int[]array)
{
    Console.Write("The resulting array -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void FindMinMaxSum (int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sumPositive = sumPositive + array[i];
        else sumNegative += array[i];
    }
    Console.WriteLine($"Сумма положительных чисел в массиве -> {sumPositive}.");
    Console.WriteLine($"Сумма отрицательных чисел в массиве -> {sumNegative}.");
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandArray(a, min, max);
PrintArray(myArray);
FindMinMaxSum(myArray);*/



//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

/*int[] CreateRandArray(int size, int minValue, int maxValue)
{
    int[]newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue,maxValue + 1);
    }
    return newArray;
}
void PrintArray(int[]array)
{
    Console.Write("The received array -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] InvertArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *=-1; // OR // array[i] = array[i] * -1;
    }
    return array;
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandArray(a, min, max);
PrintArray(InvertArray(myArray));*/



//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//+ создание метода запроса элементов массива у пользователя
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

/*int[] CreateRandArray(int size)
{
    int[]newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i+1} number ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void PrintArray(int[]array)
{
    Console.Write("The received array -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
bool FindNumber (int number, int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(number == array[i]) return true;
    }
    return false;
}
Console.WriteLine("Input size ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandArray(size);
PrintArray(myArray);
Console.WriteLine("Input your number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindNumber(number, myArray));*/




//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].
//[5, 18, 123, 6, 2] -> 1

/*int[] CreateRandArray(int size)
{
    int[]newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(0, 201);
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
void FindNumberRange(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i]<=99) count += 1;
    }
    Console.WriteLine($"Кол-во чисел {count}");
}
Console.WriteLine("Input size ");
int size = Convert.ToInt32(Console.ReadLine());
int[] MyArray = CreateRandArray(size);
PrintArray(MyArray);
FindNumberRange(MyArray);*/