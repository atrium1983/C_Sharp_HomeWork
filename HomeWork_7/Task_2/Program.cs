/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

int [,] CreateArray(int row, int col, int min, int max){
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

void PrintArray(int [,] array){
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

bool CheckElementPossition(int row, int col, int [,] array){
    return row > array.GetLength(0) && col > array.GetLength(1);
}

Console.Clear();
Print("Let's create one random matrix with numbers between -10 and 10");
int row = GetNumber("Insert number of rows");
int col = GetNumber("Insert number of columns");
int [,] array = CreateArray(row,col,-10,10);
PrintArray(array);
Console.WriteLine();
Print("To get the value of element in matrix, please insert possition");
int rowToCheck = GetNumber("Insert number of rows");
int colToCkeck = GetNumber("Insert number of columns");

string answer = CheckElementPossition(rowToCheck,colToCkeck,array) ? "Element you are looking is out of matrix"
            : $"Element on position ({rowToCheck}, {colToCkeck}) is {array[rowToCheck-1,colToCkeck-1]}";
Print(answer);