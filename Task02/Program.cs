//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деления.


using System;
using static System.Console;

Clear();

Write("Type the first number ");
int number1 = Convert.ToInt32(ReadLine());

Write("Type the second number ");
int number2 = Convert.ToInt32(ReadLine());

if (number2%number1 == 0)
{
    WriteLine("The second dumber is a multiple of the first");

}
else
{
WriteLine(number2%number1);
}