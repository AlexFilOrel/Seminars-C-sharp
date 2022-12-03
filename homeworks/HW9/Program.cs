//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*void ShowNumbers (int n)
{
    if(n >= 1)
    {
                Console.Write (n + " ");
        ShowNumbers(n - 1);
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write ($"N = {num} -> ");
ShowNumbers(num);
Console.WriteLine ();*/



//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/*int FindSumNumbers (int m, int n)
{
    if(m != n)
    {
        if(m < n)
        {
            return FindSumNumbers(m + 1, n) + m;
        }
        else
        {
            return FindSumNumbers(m,n + 1) + n;
        }
    }
    else return m;
}
Console.Write("Input number M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.Write ($"M = {numM}; N = {numN}. -> ");
int sum = FindSumNumbers(numM, numN);
Console.WriteLine (sum);*/



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

/*int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    else
    {
        return (FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1)));
    }
}


Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"m = {m}, n = {n} -> A({m},{n}) = ");
Console.Write(FunctionAkkerman(m,n));
Console.WriteLine();*/