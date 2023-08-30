/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int CountEvenPosNumbers(int [] array){
    int sum = 0;
    for (int i = 0; i < array.Length; i++){
        if(i%2 != 0){
            sum+=array[i];
        }
    }
    return sum;
}

Console.Clear();
int length = GetNumber("To create one massive insert length of massive");
int [] arr = GetRandomArray(length, -10000, 10000);
int sum = CountEvenPosNumbers(arr);
Print($"Sum of elements with odd indexes is {sum}");