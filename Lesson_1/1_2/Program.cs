﻿// 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

int a = 5;
int i = -a;

while(i <= a)
{
    Console.Write(i + " ");
    i = i + 1;
}