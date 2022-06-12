// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

using System;
using static System.Console;

Clear();

Write("Type the first number ");
int number1 = Convert.ToInt32(ReadLine());

Write("Type the second number ");
int number2 = Convert.ToInt32(ReadLine());

string answer = Math.Pow(number1,2)==number2 || Math.Pow(number2,2)==number1? "Yes":"No";
WriteLine(answer);
string answer2 = Math.Pow(number1,2)==number2
?$"{number1} is a square of {number2}":Math.Pow(number2,2)==number1?$"{number2} is a square of {number1}"
:$"{number1} is not a square of {number2} and vice versa";
Write(answer2);

