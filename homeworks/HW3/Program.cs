//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

/*bool CheckingPalindrome(int num)
{
    if((num / 10000 % 10) == (num / 1 % 10) && (num / 1000 % 10) == (num / 10 % 10))
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = CheckingPalindrome(number);
Console.WriteLine($"The number {number} is {result} palindrome.");*/



//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*double FindDistancePoint(double ax, double ay, double az, double bx, double by, double bz)
{
    double distance = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay)+(bz - az) * (bz - az));
    return distance;
}
Console.Write("Input coordinate X point A: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate Y point A: ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate Z point A: ");
double az = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate X point B: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate Y point B: ");
double by = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate Z point B: ");
double bz = Convert.ToDouble(Console.ReadLine());



double result = FindDistancePoint(ax, ay, az, bx, by,bz);
Console.WriteLine($"Distance between points A and B {Math.Round(result, 2)}.");*/



//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

/*void FindSquadNumbers (int N)
{
    Console.WriteLine($"Cube of numbers from 1 to {N}: ");
    for(int i = 1; i < N +1; i++)
    {
        Console.Write($"{i} = {i * i * i}, ");
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
FindSquadNumbers(num);*/