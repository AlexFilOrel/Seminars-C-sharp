//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

/*void FindSecondNumber(int num)
{
    int result = num / 10 % 10;
    int number = num;
    Console.WriteLine($"The second digit in the number {number} is {result}.");
}
Console.WriteLine("Input a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
FindSecondNumber(number);*/



//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*void FindThirdNumber(int num)
{
    if(num >= 100)
    {
        while(num > 999)
        {
            num = num / 10;
        }
        num = num % 10;
        Console.WriteLine($"The thrid digit numbers is {num}.");
    }
    else
    {
        Console.WriteLine("The thrid digit is missing.");
    }
    }
Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
FindThirdNumber(number);*/



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

/*bool FindWeekend(int day)
{
    if(day == 6 || day == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine("Input day of the week: ");
int dayweek = Convert.ToInt32(Console.ReadLine());
bool result = FindWeekend(dayweek);
//int numthrid = FindThirdNumber(number);
Console.WriteLine($"The {dayweek} day of the week is a {result} day off.");*/