// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

int a = 25;
int b = 5;

if (b * b == a)
    //Console.WriteLine ("true");
else
    //Console.WriteLine ("false");


//или другой способ

Console.Write("Enter a number: ");
string str1 = Console.ReadLine()!;

Console.WriteLine(str1 + str1);

int num1 = int.Parse(str1);
Console.WriteLine(num1 + num1);

//ещё короче (компактный способ записи)

Console.Write("Enter a number: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine(num1 * num1);

