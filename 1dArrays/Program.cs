int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int Summa(int num)
{
    int summa = 0;
    int sumEd2 = 0;
    if (num >= 10)
    {
        int ed = num % 10;
        int des = num / 10;
        summa = ed;
        while (des >= 10)
        {
            int des2 = des / 10;
            int ed2 = des % 10;
            sumEd2 += ed2;
            des = des2;
        }
        summa += sumEd2 + des;
    }
    else summa = num;
    return summa;
}

int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    Console.WriteLine("Creating array here: ");

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

int CountOfPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count++;
    return count;
}

/* Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Summa: " + Summa(number));

/* Задача 29. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

/*
Console.Write("Input size of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(m, min, max);
PrintArray(array);
*/

/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

/*Console.Write("Input size of array: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(m);
PrintArray(array);
Console.WriteLine("Amount of positive numbers: " + CountOfPositive(array));
*/