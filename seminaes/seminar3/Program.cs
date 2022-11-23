//Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*double FindQuart(double x, double y)
{
    if(x > 0 && y > 0)
    return 1;
    if(x < 0 && y > 0)
    return 2;
    if(x < 0 && y < 0)
    return 3;
    if(x > 0 && y < 0)
    return 4;
    return 0;
}
Console.Write("Input coordinate X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate Y: ");
double y = Convert.ToDouble(Console.ReadLine());
double result = FindQuart(x, y);
Console.WriteLine($"The point is in {result} quarter of the plane.");*/



//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*void FindCoordinats (int quart)
{
    if(quart < 1 || quart > 4)
    Console.WriteLine("Четверть отсутствует");
    if(quart == 1)
    Console.WriteLine("Диапозон координат в I четверти (x > 0; y > 0");
    if(quart == 2)
    Console.WriteLine("Диапозон координат в II четверти (x < 0; y > 0");
    if(quart == 3)
    Console.WriteLine("Диапозон координат в III четверти (x < 0; y < 0");
    if(quart == 4)
    Console.WriteLine("Диапозон координат в IV четверти (x > 0; y < 0");
}
Console.Write("Input quart number: ");
int quart = Convert.ToInt32(Console.ReadLine());
FindCoordinats (quart);*/



//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

/*double FindDistancePoint(double ax, double ay, double bx, double by)
{
    double distance = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
    return distance;
}
Console.Write("Input coordinate X point A: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate Y point A: ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate X point B: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate Y point B: ");
double by = Convert.ToDouble(Console.ReadLine());
double result = FindDistancePoint(ax, ay, bx, by);
Console.WriteLine($"Distance between points A and B {result}.");*/



//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N

/*void FindSquadNumbers (int N)
{
    Console.WriteLine($"The square of numbers from 1 to {N}: ");
    for(int i = 1; i < N +1; i++)
    {
        Console.Write($"{i} = {i * i}, ");
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
FindSquadNumbers(num);*/

//?????????????????????????????
/*double GetLens(int x1,int y1,int z1, int x2,int y2,int z2)
{
    double len = Math.Sqrt((x1-x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return len;
}
Console.WriteLine(GetLens(3, 6, 8, 2, 1, -7));*/
