//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*int Exponentiation(int num1, int num2)
{
    int exp = num1;
    for (int i = 1; i < num2; i++)
    {
        exp = exp * num1;
    }
    return exp;
}
Console.WriteLine("Input number A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = Exponentiation(number1, number2);
Console.WriteLine($"The number {number1} increased to the exponent of {number2} is a number {result}.");*/



//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*int SumDigitNumber(int num) 
{
    int sum = 0;
    for(; num > 0; num = num / 10) 
    {
        sum = sum + num % 10;
    }
    return sum;
}
Console.WriteLine("Input number : ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumDigitNumber(number);
Console.WriteLine($"The sum of the digits of {number} is {result}.");*/



//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

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
Console.WriteLine("Input size ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandArray(size);
PrintArray(myArray);*/