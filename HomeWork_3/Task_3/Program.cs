//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void Print (string text){ 
   Console.WriteLine(text);
}

int GetIntNumber(){ 
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number; 
} 

void GetCube(int number){
    for (int i=1;i<=number;i++){
        int pow = 3;
        Console.Write($"{Math.Pow(i,pow)} ");
    }
}

Print("To see cubes of the numbers from 1 to N enter N (but not higher than 20): ");
int number = GetIntNumber();
if (number > 20 || number < 1){ 
    Print("Please enter number from 1 to 20");
}
else{
    GetCube(number);
}
