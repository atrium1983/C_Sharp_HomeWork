/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
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
        Print($"This number {temp} is not correct. Try again. => ");
    }
}

int[] GetRandArray(int length, int min, int max){ 
    int[] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    Print($"Inicial massive is {array}");
    return array;
}

int length = GetNumber("Insert length of massive");
int [] arr = GetRandArray(length, 0, 200);
Print($"[{string.Join(", ", arr)}]");