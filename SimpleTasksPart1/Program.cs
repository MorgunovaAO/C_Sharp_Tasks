/*Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

int a, b;

Console.Write("Input a first number: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.WriteLine("max = " + a + ", min = " + b);
else
    Console.WriteLine("max = " + b + ", min = " + a);

/*Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

/*int a, b, c, max; 

Console.Write("Input a first number: "); 
a = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input a second number: "); 
b = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input a third number: "); 
c = Convert.ToInt32(Console.ReadLine()); 

max = a; 

if (b > max) max = b; 
if (c > max) max = c; 

Console.WriteLine("max = " + max); 
*/

/*Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4->да
- 3->нет
7->нет*/

/*int num; 

Console.Write ("Input a number: "); 

num = Convert.ToInt32(Console.ReadLine()); 

if (num % 2 == 0) 
{ 
    Console.WriteLine(num + " is an even number."); 
} 
else 
{ 
    Console.WriteLine(num + " is an odd number."); 
} 
*/

/*Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

/*int n, current; 

Console.Write ("Input a number: "); 
n = Convert.ToInt32(Console.ReadLine()); 

current = 2; 

while (current <= n) 
{ 
    if (current % 2 == 0) 
        Console.Write(current + " "); 
    current ++; 
} 
*/