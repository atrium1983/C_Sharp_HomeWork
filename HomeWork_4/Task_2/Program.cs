/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

void Print (string text){ 
   Console.WriteLine(text);
}

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

int GetDigitSum(int number){
    int sum = 0;
    while(number>0){
        sum += number%10;
        number/=10;
    }

    return sum;
}

int number = GetNumber("Insert number ");
int sum = GetDigitSum(number);
Print($"Sum of all digits in number is {sum}");