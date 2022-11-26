//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

/*int FindSum (int num)
{
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = FindSum(number);
Console.WriteLine($"The sum of the numbers from 1 to {number} is {result}.");*/



//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

/*int FindQuantityDigits(int num)
{
    int count = 0;
    
    while(num > 0)
    {
      num = num / 10;
      count++;
    }
    for (count = 0; a > 0; count++){
        a = a / 10;
    }
    return count;
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = FindQuantityDigits(number);
Console.WriteLine($"Quantity of digits in a number {number} is {result}.");*/

//-----------------------------

/*int FindQuantityDigits(int num)
{
    int count = 0;
    for (count = 0; num > 0; count++)
    {
        num = num / 10;
    }
    return count;
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = FindQuantityDigits(number);
Console.WriteLine($"Quantity of digits in a number {number} is {result}.");*/



//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4  -> 24
//5  -> 120

/*int Factorial(int num)
{
    if(num == 1) return 1;
    else return num * Factorial(num - 1);
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Factorial(number);
Console.WriteLine($"The product of numbers from 1 to {number} is {result}.");*/

//----------------------------------------------

/*int Factorial(int num)
{
    int result = 1;
    for(int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Factorial(number);
Console.WriteLine($"The product of numbers from 1 to {number} is {result}.");*/



//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

/*void FillArray (int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,2);
        Console.Write($"{array[i]} ");
    }
}
FillArray (8);*/

//--------------------------------------

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
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandArray(a, min, max);
PrintArray(myArray);*/