// See https://aka.ms/new-console-template for more information
// 10. Write a program to check whether a year is leap year or not ?

using System.ComponentModel.Design;

int year;

Console.WriteLine("enter a year");
year = Convert.ToInt32(Console.ReadLine());

if (year % 4 == 0) 
{
    Console.WriteLine("it is a leap year");
}
else
{
    Console.WriteLine("it is not a leap year");
}
