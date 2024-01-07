// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

using System;

    int n_min = 10;
    int n_max = 99;

    Console.Write("Enter Number (range "+n_min+" to "+n_max+"):");
    int n = int.Parse(Console.ReadLine()!);
    
    if(n<n_min || n>n_max) { 
        Console.Write("Number is not in range!");
        System.Environment.Exit(0);
    }
    
    int division_result = n/10;
    int remainder_result = n % 10;
    int largest_n = (division_result>remainder_result) ? division_result : remainder_result;
    
    Console.Write("Largest number:" +largest_n);