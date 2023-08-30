/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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

int CalcAckerman(int m, int n){
    if(m == 0) return n + 1;
    else{
        if(n == 0) return CalcAckerman(m - 1, 1);
        else return CalcAckerman(m - 1, CalcAckerman(m, n - 1));
        }
}

Console.Clear();
Console.WriteLine("To calculate the Ackerman function, enter two non-negative integer numbers: M and N");
int m = GetNumber("Enter M ");
int n = GetNumber("Enter N ");
if (n >= 0 && m >= 0)
{
    if((m < 5) && (m < 4 && n < 6) || (m == 4 && n < 2) || m == 0) //Добавлены условия проверки, т.к. основные результаты слишком велики
        Console.WriteLine($"Result is {CalcAckerman(m,n)}");
    else 
        Console.WriteLine($"Result for M = {m} and N = {n} is too big. Try another numbers.");
}
else 
    Console.WriteLine("Numbers should be non-negative");
