/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

void PrintArray(double [] array){
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

double[] GetRandomRealArray(int length, int min, int max){ 
    double[] array = new double [length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round((rand.NextDouble() * rand.Next(min,max+1)),2);
    }
    Print($"Random massive of real numbers with {length} elements is: ");
    PrintArray(array);
    return array;
}

double [] BubbleSort (double [] array){
    double temp = 0;
    for (int i = 0; i < array.Length; i++) {
        for (int j = 0; j < array.Length - 1; j++) {
            if (array[j] > array[j + 1]) {
                temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
        }
    }
    Print("Sorted massive:");
    PrintArray(array);
    return array;
}

double GetDifference (double [] array){
    return Math.Round((array[array.Length-1] - array[0]),2);
}

Console.Clear();
int length = GetNumber("To create one massive of real numbers insert length of massive");
double [] arr = GetRandomRealArray(length, 0, 100);
double [] sortedArr = BubbleSort(arr);
Print($"Difference between max and min in massive is {GetDifference(sortedArr)}");