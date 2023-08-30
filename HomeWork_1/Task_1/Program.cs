/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");
Console.Write("Insert number 1 :");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert number 2 :");
double number2 = Convert.ToDouble(Console.ReadLine());
if(number1 > number2)
    Console.Write($"{number1} is bigger than {number2}");
else
     Console.Write($"{number2} is bigger than {number1}");