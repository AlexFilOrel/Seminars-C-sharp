//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

/*void ShowNumbers (int n)
{
    if(n >= 1)
    {
        ShowNumbers(n - 1);//рекурсия
        Console.Write (n + " ");
    }
}
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNumbers(num);
Console.WriteLine ();*/



//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9

/*int FindSum (int num)
{
    if(num != 0)
    {
        return FindSum(num / 10) + num % 10;
    }
    else
    return num;
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = FindSum(num);
Console.WriteLine (sum);
Console.WriteLine ();*/



//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

/*void ShowNumbers (int m, int n)
{
    if(m != n)
    {
        if(n > m)
        {
            ShowNumbers(m,n - 1);//рекурсия
            Console.Write (n + " ");
        }
        else
        {
            ShowNumbers(m - 1,n);//рекурсия
            Console.Write (m + " ");
        }
    }
    else Console.Write (m + " ");
}
Console.WriteLine("Input number m: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number n: ");
int numN = Convert.ToInt32(Console.ReadLine());
ShowNumbers(numM,numN);
Console.WriteLine ();*/


//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

/*int FindExtent (int a, int b)
{
    if (b == 0) return 1;
    else
    {
        return FindExtent(a,b - 1) * a;
    }
}

Console.WriteLine("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());
int extent = FindExtent(a, b);
Console.WriteLine (extent);
Console.WriteLine ();*/