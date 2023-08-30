//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int GetNumber ()
{
    Console.Write("Введите любое число : ");
    int number = Convert.ToInt32(Console.ReadLine());

    return number;
}

int ReverseNumber(int number)
{
    string s = number.ToString();
    char [] ar = s.ToCharArray();
    Array.Reverse(ar);
    s = new String(ar);
    number = Convert.ToInt32(s);
    Console.WriteLine();
    return number;
}

int number = GetNumber();
int reversNumber = ReverseNumber(number);
int result = reversNumber/100;
if (result == 0) Console.WriteLine($"В числе отсутствует третья цифра");
else 
    {
        result = result%10;
        Console.WriteLine($"Третья цифра числа это {result}");
    }