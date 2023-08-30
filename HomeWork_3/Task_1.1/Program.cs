//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

void Print(string text){
    Console.WriteLine(text);
}

int GetIntNumber(){ 
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number; 
}

int GetReverse(int number){
    int numberToReverse = number;
    int reverse = 0;
    while (numberToReverse > 0){
        reverse = reverse*10 + numberToReverse%10;
        numberToReverse/=10;
    }
    return reverse;
}

Print("Enter five-digit number ");
int number = GetIntNumber();
if (number > 99999 || number < 10000){ 
    Print("Number that you has been entered is not five-digit number");
}
else{
    int reverse = GetReverse(number);
    if (number == reverse)
        Print($"Yes, entered number {number} is polindrom");
    else
        Print($"No, entered number {number} is not polindrom");
}

