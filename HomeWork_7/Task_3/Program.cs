/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

int [,] CreateRandomMatrix(int row, int col, int min, int max){
    Random rand = new Random();
    int [,] array = new int [row,col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = rand.Next(min,max+1);
        }
    }
    return array;
}

void Print (string text){ 
   Console.WriteLine(text);
}

void PrintMatrix(int [,] array){
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{array [i,j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintYellowArray(double [] array){
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{string.Join(", ", array)}");
    Console.ResetColor();
}

double [] GetColArithmeticMean(int [,] array){
    double [] sumInColumnArray = new double [array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            temp = temp + array[i,j];
        }
        sumInColumnArray[j] = (double)temp / array.GetLength(0);
    }
    return sumInColumnArray;
}

Console.Clear();
Print("Let's get arithmetic mean of each column");
int row = GetNumber("Insert number of rows");
int col = GetNumber("Insert number of columns");
int [,] array = CreateRandomMatrix(row,col,0,10);
PrintMatrix(array);
Console.WriteLine();
double [] colArithmeticMean = GetColArithmeticMean(array);
Print("Arithmetic means of each column are follows:");
PrintYellowArray(colArithmeticMean);