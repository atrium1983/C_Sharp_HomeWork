/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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

int [,] CreateNullMatrix(int row, int col){
    int [,] array = new int [row,col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            array[i,j] = 0;
    }
    return array;
}

double GetTriangleBase (int a, int b){
    double c = Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
    return c;
}

int [,] GetSpiralMatrix(int [,] array){
    int m = 1;
    int n = 0;
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int maxTurn = (int)(GetTriangleBase(row,col)/2);
    while(n<maxTurn){
        for (int i = n, j = n; j < col-n; j++)
        {
            if(array[i,j] == 0){ 
                array[i,j] = m;
                m++;
             }
        }
        for (int i = n+1, j = col-1-n; i < row-n; i++)
        {
             if(array[i,j] == 0){ 
                array[i,j] = m;
                m++;
             }
        }
        for (int i = row-1-n, j = col-2-n; j >= 0; j--)
        {
             if(array[i,j] == 0){ 
                array[i,j] = m;
                m++;
             }
        }
        for (int i = row-1-n, j = n; i > n; i--)
        {
            if(array[i,j] == 0){ 
                array[i,j] = m;
                m++;
             }
        }
        n++;
    }
    return array;
}

Console.Clear();
int row = GetNumber("To create spiral matrix insert number of rows");
int col = GetNumber("Insert number of cols");
int [,] array = CreateNullMatrix(row, col);
array = GetSpiralMatrix(array);
PrintMatrix(array);
