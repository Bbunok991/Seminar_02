/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

using System;
Console.Write("Enter a digit: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 6 && number == 7)
{
    Console.WriteLine("This day is a day off.");
}
else Console.WriteLine("This day is a weekday.");






