/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

void Print (string text){ 
   Console.WriteLine(text);
}

void PrintArray(int [] array){
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

int GetNmber(string description){
    int number;
    Console.Write($"{description} => ");

    while(true){
        string? temp = Console.ReadLine();
        if(int.TryParse(temp, out number))
            return number;
    
        Console.Write($"This number {temp} is not correct. Try again. => ");
    }
}

int [] CreateUserArray(int m){
    int [] userArray = new int [m];
    Print($"Please, insert {m} any positive and negative integer numbers");
    for (int i = 1; i <= m; i++)
        userArray[i-1] = GetNmber($"{i}");

    return userArray;
}

int CountPositiveNumbers(int [] array){
    int count = 0;
    foreach (int i in array)    
        if(i>0) count++;
    
    return count;
}


Console.Clear();
int m = GetNmber("Write quantity of number that you would like to input");
int [] userArray = CreateUserArray(m);
Print("You inserted the following numbers:");
PrintArray(userArray);
int posNumbers = CountPositiveNumbers(userArray);
Print($"From the numbers you are inserted, {posNumbers} is/are positive");