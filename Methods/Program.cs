void Palindrom(int num)
{
    int ed = num % 10;
    int des = (num % 100) / 10;
    int thousand = (num / 1000) % 10;
    int tenthousand = num / 1000 / 10;

    if (ed == tenthousand && des == thousand) Console.WriteLine("True");
    else Console.WriteLine("False");
}

void Cub(int num)
{
    int current = 1;
    while (current <= num)
    {
        int cub = current * current * current;
        Console.Write(cub + " ");
        current++;
    }
}

double IntersectionPoint(double a1, double m1, double a2, double m2)
{
    double x = (a2 - a1) / (m1 - m2);
    double y = m1 * x + a1;
    Console.WriteLine($"Intersection coordinates: x = {x}, y = {y}");
    return x;
    return y;
}

/*Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Input a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrom(number);

/*Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Cub(n);
*/

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

/*
Console.Write("Input b1: "); 
double b1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Input k1: "); 
double k1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Input b2: "); 
double b2 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Input k2: "); 
double k2 = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine(IntersectionPoint(b1, k1, b2, k2)); 
*/