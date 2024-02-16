using System;

//function
void printNumber(int m, int n) { 
    if(m>n)
        return;
    if (m % 2 == 0) {
        Console.Write($"{m},");
    }
    printNumber(m+1,n);
}


Console.Write("Lesson 7.2.2\n");

Console.Write("Enter natural number M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter natural number N:");
int n = Convert.ToInt32(Console.ReadLine());

if(m<=0 || n<=0)
    Console.Write("Not a natural numbers:");

printNumber(m,n);
