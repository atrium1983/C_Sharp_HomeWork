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

Print("Enter five-digit number ");
int number = GetIntNumber();
if (number > 99999 || number < 10000){ 
    Print("Number that you has been entered is not five-digit number");
}
else{
    int number1 = number/10000;
    int number2 = (number/1000)%10;
    int number4 = (number/10)%10;
    int number5 = number%10;

    if (number1 !=0 && number1 == number5 && number2 == number4 )
        Print($"Yes, entered number {number} is polindrom");
    else
        Print($"No, entered number {number} is not polindrom");
}
