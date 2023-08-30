/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/
void Print (string text){ 
    Console.Write(text);
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
    Console.WriteLine();
}

bool CheckPossibility (int [,] array1, int [,] array2){
        return array1.GetLength(1) != array2.GetLength(0);
}

int [,] GetProductOfArrays(int [,] array1, int [,] array2){
    int [,] productArray = new int [array1.GetLength(0),array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int n = 0; n < array1.GetLength(1); n++)
            {
                productArray[i,j] += array1[i,n] * array2[n,j];
            }
        }
    }
    return productArray;
}

Console.Clear();
int rowsArray1 = GetNumber("To create matrix 1 insert number of rows");
int colsArray1 = GetNumber("To create matrix 1 insert number of cols");
int rowsArray2 = GetNumber("To create matrix 2 insert number of rows");
int colsArray2 = GetNumber("To create matrix 2 insert number of cols");
Console.Clear();
int [,] array1 = CreateRandomMatrix(row: rowsArray1, col: colsArray1, min: 0, max: 10);
PrintMatrix(array1);
int [,] array2 = CreateRandomMatrix(row: rowsArray2, col: colsArray2,min: 0, max: 10);
PrintMatrix(array2);
if(CheckPossibility(array1, array2))
    Print("To find product of two matrixes the number of cols of the first and number of rows of the second should be equal");
else 
    PrintMatrix(GetProductOfArrays(array1,array2));