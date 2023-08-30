//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int GetNumber(int number)
{
    int result = (number/10)%10;

    return result;
}

int CreateRandomNumber(int min, int max)
{
    Random rand = new Random();
    int resultRandom = rand.Next(min,max+1);

    return resultRandom;

}

int AskingForMin()
{
    Console.Write($"от ");
    int min = Convert.ToInt32(Console.ReadLine());
    
    return min;
}

int AskingForMax()
{
    Console.Write($"до ");
    int max = Convert.ToInt32(Console.ReadLine());
    
    return max;
}

Console.WriteLine($"Выберите диапазон создания случайного трёхзначного числа (от 100 до 999):");
int min = AskingForMin();
int max = AskingForMax();
int newRandomNumber = CreateRandomNumber(min, max);
int secondNumber = GetNumber(newRandomNumber);
Console.Write($"Вторая цифра случайного числа {newRandomNumber} => {secondNumber}");