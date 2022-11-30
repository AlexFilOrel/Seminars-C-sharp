//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

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
void FindPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    Console.WriteLine($"The number of numbers greater than 0 is {count}.");
}
Console.WriteLine("Input size ");
int size = Convert.ToInt32(Console.ReadLine());
int[] MyArray = CreateRandArray(size);
PrintArray(MyArray);
FindPositiveNumbers(MyArray);*/



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*double[] SolvingSystemEquations(double k1, double b1, double k2, double b2)
{
    double[] intersectionPoint = new double [2];
    intersectionPoint[0] = (b2 - b1) / (k1 - k2);
    intersectionPoint[1] = intersectionPoint[0] * k1 + b1;
    return intersectionPoint;
}

void PrintResult(double k1, double b1, double k2, double b2)
{
  if (k1 == k2 && b1 == b2) 
  {
    Console.Write($"Straight lines match.");
    Console.WriteLine();
  }
  else if (k1 == k2 && b1 != b2) 
  {
    Console.Write("Straight lines are parallel.");
    Console.WriteLine();
  }
  else 
  {
    double[] result = SolvingSystemEquations(k1, b1, k2, b2);
    Console.Write($"Point of intersection of straight lines: ({result[0]}, {result[1]})");
    Console.WriteLine();
  }
}
Console.WriteLine("Input the value k of the first equation: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the value b of the first equation: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the value k of the second equation: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the value b of the second equation: ");
double b2 = Convert.ToDouble(Console.ReadLine());
PrintResult(k1, b1, k2, b2);*/