/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

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
            Console.Write($"{array [i,j]}\t");
        }
        Console.WriteLine();
    }
}

int [,] GetSortedRowsMatrix (int [,] array){
    int min = 0;
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++) 
    {
        for (int m = 0; m < col-1; m++)
        {
            int j = 0;
            while(j < col-1) 
            {
                if (array[i,j] < array[i,j+1]) {
                    min = array[i,j+1];
                    array[i,j+1] = array[i,j];
                    array[i,j] = min;
                }
                j++;
            }
        }
    }
    return array;
}

int [,] array = CreateRandomMatrix(5,5,0,10);
PrintMatrix(array);
Console.WriteLine();
int [,] sortedArray = GetSortedRowsMatrix (array);
PrintMatrix(sortedArray);
