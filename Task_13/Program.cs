/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

using System;
int Input(string message)
{
    Console.Write(message);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result;
if(number >= 100)
{
    while(number > 999)
    {
        number = number / 10;
    }
    Console.WriteLine(number % 10);
}
else Console.WriteLine("There is no third digit.");










