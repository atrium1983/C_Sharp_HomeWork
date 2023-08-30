/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int [,,] CreateMatrix(int row, int col, int deep){
    int [,,] array = new int [row,col,deep];
    int n = 11;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < deep; k++)
            {
                array[i,j,k] = n++;
            }
        }
    }
    return array;
}

int [,,] DoRandomMatrix (int [,,] array){
    Random rand = new Random();
    int temp, m, n, h = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            { 
                temp = array[i,j,k];
                m = rand.Next(0,array.GetLength(0));
                n = rand.Next(0,array.GetLength(1));
                h = rand.Next(0,array.GetLength(2));
                array[i,j,k] = array[m,n,h];
                array[m,n,h] = temp;
            }
        }
    }
    return array;
}

void PrintElementsIndex(int [,,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array [i,j,k]} ({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Clear();
int [,,] array = CreateMatrix(row: 3, col: 3, deep: 3);
array = DoRandomMatrix(array);
PrintElementsIndex(array);
