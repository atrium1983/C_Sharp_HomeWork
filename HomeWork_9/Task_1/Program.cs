/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber(string description){
    int number;
    Console.Write($"{description} => ");
    while(true){
        string? temp = Console.ReadLine();
        if(int.TryParse(temp, out number)){
            return number;
        }
        Console.Write($"This number {temp} is not correct. Try again. => ");
    }
}

string ReturnNaturalNumbers(int number){
    if(number == 1) return number.ToString();
    return number + ", " + ReturnNaturalNumbers(number-1);
}
Console.Clear();
int n = GetNumber("To get all natural numbers from one number to 1 insert positive integer number greater than 0 ");
if (n>=1) Console.WriteLine($"{n} ->  {ReturnNaturalNumbers(n)}");
else Console.WriteLine($"Number {n} is not positive integer number greater than 0");