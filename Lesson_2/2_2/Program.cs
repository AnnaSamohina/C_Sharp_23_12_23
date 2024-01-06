//Напишите программу, которая принимает на вход трёхзначное число и возводит вторую цифру этого числа в степень, равную третьей цифре.

int a = int.Parse(Console.ReadLine()!);
int SecondNumber = a / 10 % 10 ;
int thirdNumber = a % 10;
Console.WriteLine (Math.Pow(SecondNumber,thirdNumber));