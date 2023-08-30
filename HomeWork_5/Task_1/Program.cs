/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void PrintArray(int [] array){
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

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

int[] GetRandomArray(int length, int min, int max){ 
    int[] array = new int [length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(min, max);
    }
    Print($"Random massive of {length} elements is: ");
    PrintArray(array);
    return array;
}

int GetEvenNumbersCount(int [] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
            count+=1;
    }
    return count;
}
Console.Clear();
int length = GetNumber("To get quantity of even numbers in random massive of positive three-digits numbers insert length of massive");
int [] arr = GetRandomArray(length, 100, 999);
int count = GetEvenNumbersCount(arr);
Print($"Number of even numbers in massive is {count}");