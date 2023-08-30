//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Again:
Console.Write("Введите цифру, соответствующую дню недели, и узнайте, является ли этот день выходным => ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Нет");
        break;
    case 6:
    case 7:
        Console.WriteLine("Да");
        break;
    default:
         Console.WriteLine("ОШИБКА!!! ОШИБКА!!! Введенная цифра не соответствует дню недели");
         goto Again;
}