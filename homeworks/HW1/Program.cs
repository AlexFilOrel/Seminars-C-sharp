﻿/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

/*Console.WriteLine("Input number 1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2 ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2)
{
    Console.WriteLine($"{num1} more then {num2}");
}
else
{
    Console.WriteLine($"{num1} less then {num2}");
}*/


/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

/*Console.WriteLine("Input number 1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2 ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 3 ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine($"The maximim number is {max}");*/



/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

/*Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine($"The number {num} is even");
}
else
{
    Console.WriteLine($"The number {num} is odd");
}*/



/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/
//SO

/*Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
int even = 2;
while(even <= num)
{
    if(even % 2 == 0)
    {
        Console.Write(even + "  ");
        even = even + 2;
    }
}*/

//OR SO

/*Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
int even = 1;
while(even <= num)
{
    if(even % 2 == 0)
    {
        Console.Write(even + "  ");
        even = even + 1;
    }
    else
    {
        even = even + 1;
    }
}*/