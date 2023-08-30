/*
Урок 7. Двумерные массивы
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
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

double[,] GetRandomRealMatrix(int row, int col, int min, int max){ 
    double[,] array = new double [row,col];
    Random rand = new Random();
   for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            array[i,j] = Math.Round((rand.NextDouble() * rand.Next(min,max+1)),2,MidpointRounding.ToZero);
    }
    return array;
}

void PrintArray(double [,] array){
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

Console.Clear();

int row = GetNumber("Insert number of rows");
int col = GetNumber("Insert number of columns");
double [,] array = GetRandomRealMatrix(row,col,-10,10);
PrintArray(array);
Console.WriteLine();