//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

/*int[] CreateRandArray(int size)
{
    int[]newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(0, 1000);
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
int[] RevrseArray (int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}
Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandArray(size);
PrintArray(myArray);
PrintArray(RevrseArray(myArray));*/



//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

/*bool CheckTriangle (int a, int b, int c)
{
    if(a+b>c && b+c>a && c+a>b)
    return true;
    return false;
}
int CheckNumber ()
{
    int x = Convert.ToInt32(Console.ReadLine());
    if(x <= 0) return CheckNumber();
    else return x;
}
Console.WriteLine("Input number A: ");
int a = CheckNumber ();
Console.WriteLine("Input number B: ");
int b = CheckNumber ();
Console.WriteLine("Input number C: ");
int c = CheckNumber ();
Console.WriteLine($"The existence of a triangle with sides {a}, {b} and {c} is {CheckTriangle(a,b,c)}.");*/



//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[0, 1,2, 3, 5, 8, 13, ... ]

/*int[] Fibonacci(int a, int b, int n)
{  
    int [] newArray = new int [n]; 
    newArray[0] = a;
    newArray[1] = b;
      for (int i = 2; i < n; i++)
      {
        newArray[i] = newArray[i-1] + newArray[i-2];
      }
      return newArray;
}
void ShowArray(int [] array)
{
    Console.Write("The received Fibonacci numbers -> ");

    for(int i = 0;i < array.Length;i++ )
    {
        Console.Write (array[i]+" ");
    }
    Console.WriteLine();
}
    int a = 0;
    int b = 1;
    Console.WriteLine("Input number of Fibonacci numbers: ");
    int n = Convert.ToInt32(Console.ReadLine());
ShowArray(Fibonacci(a,b,n));*/



//Задача 4. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10  

/*string TransformToBinary(int num)
{
    string result = String.Empty;// пустая строка
    int binarynum;
    while (num > 0)
    {
        binarynum = num % 2;
        result = binarynum + result;//+ сиволы 1 или 0
        num = num / 2;
    }
    return result;
}
Console.WriteLine("Input number: ");
int res = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The number {res} in binary calculus is {TransformToBinary(res)}.");*/