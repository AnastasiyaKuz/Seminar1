// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.WriteLine("Enter numberA : ");
Console.WriteLine("Enter numberB : ");

string strNumA = Console.ReadLine();
string strNumB = Console.ReadLine();

int numberA = Convert.ToInt32(strNumA); 
int numberB = Convert.ToInt32(strNumB); 

if (numberA == numberB * numberB)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}


