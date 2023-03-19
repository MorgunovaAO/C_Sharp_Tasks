/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int CutNumber(int num)
{
    int des = (num % 100) / 10;
    return des;
}
Console.Write("Input a number between 100 and 999: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CutNumber(number));

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*int ThirdPosition (int number)
{
    while (number > 1000) 
        number = number / 10;
    if (number > 99) number = number % 100 % 10;
        else Console.WriteLine("The third position is absent");
    return number;
}
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ThirdPosition(n));
*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

/*void Weekend (int num)
{
    if (num == 6 || num == 7) Console.WriteLine("Yes");
    if (num > 1 && num < 6) Console.WriteLine("No");
    if (num < 1 || num > 7) Console.WriteLine("Uncorrect number!");
}

Console.WriteLine("Input a day's number: ");
int day = Convert.ToInt32(Console.ReadLine());
Weekend (day);
*/