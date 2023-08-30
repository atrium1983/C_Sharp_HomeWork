/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

1. Точка пересечения (x,y):
x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1

2. Прямые не пересекаются, если k1 = k2;
3. Бесконечное множество точек пересечения, т.к. прямые совпадают, если k1 = k2 и b1 = b2;
*/

void Print (string text){ 
   Console.WriteLine(text);
}

int GetNmber(string description){
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

(float CoordX, float CoordY) GetIntersectionPoint(int b1, int k1, int b2, int k2){
    float x = (float)(b2 - b1) / (k1 - k2);
    float y = (float)(k1 * x) + b1;
    return (CoordX: x, CoordY: y);
}

void CheckLines (int b1, int k1, int b2, int k2){
    int option = 0;
    if(b1 == b2 && k1 == k2) option = 1;
    if(k1 == k2 && b1 != b2) option = 2;

    switch (option){
        case 1:
            Print("Lines have an infinite set of intersection points");
            break;
        case 2:
            Print("Lines does't have any intersection points, they are parallel");
            break;
        default:
            var tuple = GetIntersectionPoint(b1, k1, b2, k2);//создание переменной для кортежа, чтобы обращаться к его элементам
            Print($"Intersection point is x = {tuple.CoordX}, y = {tuple.CoordY} ");
            Print($"{GetIntersectionPoint(b1, k1, b2, k2)}");//вывод кортежа напрямую
            break;
    }
}
  

Console.Clear();
int b1 = GetNmber("Insert b1 "),
    k1 = GetNmber("Insert k1 "),
    b2 = GetNmber("Insert b2 "),
    k2 = GetNmber("Insert k2 ");

CheckLines(b1, k1, b2, k2);