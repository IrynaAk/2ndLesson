// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

using System;
using static System.Console;

Clear();

Write("Type the first number ");
int number = Convert.ToInt32(ReadLine());

string answer = number%7 == 0 && number%23 == 0?"Yes":"No";
Write(answer);