/* 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
Дополнительно: числа А и В это max и min массива случайных чисел и случайной длины.
3, 5 -> 243 (3⁵)
2, 4 -> 16 
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

void RaiseToPow(int number, int pow){
    int result = 1;
    for (int i = 0; i < pow; i++)
    {
        result*=number;
    }
    Print($"Result of raising of number {number} to pow {pow} is {result}");
}

// создание массива случайных чисел от 1 до 10
int[] GetRandArray(int length, int max, int min){ 
    int[] array = new int [length];
    int i = 0;
    while(i<length){
        array[i] = new Random().Next(min, max);
        i++;
    }
    Print($"[{string.Join(", ", array)}]");
    return array;
}

// Сортировка массива от min до max (метод пузырька):
int[] BubleSort(int [] array){
    int temp = 0;
    for (int i = 0; i < array.Length; i++) {
        for (int j = 0; j < array.Length - 1; j++) {
            if (array[j] > array[j + 1]) {
                temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
        }
    }

    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
    return array;
}

Console.Clear();
int numberA = GetNumber("Please, insert maximum value of number (1 to 10) to be raised in power ");
int numberB = GetNumber("Please, insert maximal power (1 to 5)");

int length = new Random().Next(2,10);
int[] array = GetRandArray(length, numberA, numberB);
int[] sortedArray = BubleSort(array);
RaiseToPow(array[length-1], array[0]);