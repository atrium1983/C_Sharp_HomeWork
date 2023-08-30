/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void Print (string text){ 
   Console.Write(text);
}

int [,] CreateRandomMatrix(int row, int col, int min, int max){
    Random rand = new Random();
    int [,] array = new int [row,col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            array[i,j] = rand.Next(min,max+1);
    }
    return array;
}

void PrintMatrix(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Print($"{array [i,j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int FindMinRowSum (int [,] array){
    int rowMin = 0;
    int sumMin = 0;
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum+=array[i,j];
        }
        if (i == 0) sumMin = sum;
        if(sum < sumMin){
            sumMin = sum;
            rowMin = i;
        }
    }
    return rowMin+1;
}

void PrintRowInColor (int [,] array, int row){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i != row)
                Console.Write($"{array[i,j]}\t");
            else{
                Console.ForegroundColor = ConsoleColor.Yellow;
                Print($"{array [i,j]}\t");
                Console.ResetColor();
            }
        }
        Console.WriteLine();
    }
}

Console.Clear();
int [,] array = CreateRandomMatrix(6,4,0,10);
PrintMatrix(array);
int rowMin = FindMinRowSum(array);
Print($"Minimal sum of elements located in row => {rowMin}");
Console.WriteLine();
PrintRowInColor(array: array, row : rowMin - 1);