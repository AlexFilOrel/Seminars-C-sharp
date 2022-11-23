//Задача 1. Напишите программу, которая выводит случайное число на отрезке [10, 99] и покеазывает наибольшую цифру числа.
//78 -> 8
//12 -> 2
//85 -> 8

/*int FindBiggestDigit(int num)
{
    int ed = num % 10;
    int dec = num / 10;
    if(ed > dec)
    {
        return ed;
    }
    else
    {
        return dec;
    }
}

int rand = new Random().Next(10,100);
int result = FindBiggestDigit(rand);
Console.WriteLine($"The biggest digit jf the number {rand} is {result}.");*/



//2 Задача.Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

/*int CutNumber (int num)
{
    int ed = num % 10;
    int sot = num / 100;
    int res = sot * 10 + ed;
    return res;
}

int rand = new Random().Next(100,1000);
int result = CutNumber(rand);
Console.WriteLine($"New version {rand} is {result}.");*/



//Задача 3.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4  -> кратно

/*void Cratnoe(int num1, int num2)
{
    if(num2 % num1 == 0)
    {
        Console.WriteLine($"The number {num2} is a multiple of the number {num1}.");
    }
    else
    {
        int necrat = num2 % num1;
        Console.WriteLine($"The number {num2} is not a multiple of the number {num1}, the remainder {necrat}.");
    }
}
int number1 = new Random().Next(1,1000);
int number2 = new Random().Next(1,1000);
Cratnoe(number1, number2);*/



//4 Задача.Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14  ->  нет
//46  ->  нет
//161 ->  да

/*bool Cratnoe(int num)
{
     if(num % 7 == 0 && num % 23 == 0)
    {
       return true;
    }
     else
    {
       return false;
    }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
//int number = new Random().Next(1,1000);
bool result = Cratnoe(number);
Console.WriteLine($"The multiplicity of the number {number} to the numbers 7 & 23 is {result}.");*/