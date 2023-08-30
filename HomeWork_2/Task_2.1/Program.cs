//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int GetNumber (){
    Console.Write("Введите любое число : ");
    int number = Convert.ToInt32(Console.ReadLine());

    return number;
}

int GetThirdNumber(int number){
    while(number > 999){
        number /= 10; 
    }
    
    return number % 10;
}

int number = GetNumber();
if (number>100){
    int result = GetThirdNumber(number);
    Console.WriteLine($"Третья цифра числа это {result}");
}
else{
    Console.WriteLine($"В числе отсутствует третья цифра");
}