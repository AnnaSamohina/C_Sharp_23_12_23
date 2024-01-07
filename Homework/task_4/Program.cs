// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

using System;

int n=0;
string result="";

Console.Write("Enter a natural number: ");
n = int.Parse(Console.ReadLine()!);

if(n<=0) { 
    Console.Write(n+" is not a natural number!");
    System.Environment.Exit(0);
}

string n_str = n.ToString();

for (int i = 0; i < n_str.Length; i++) { 
    result += n_str[i]+",";
}

//delete comma
result = result.Substring(0,result.Length-1);

Console.Write(result);
