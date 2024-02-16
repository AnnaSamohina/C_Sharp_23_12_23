using System;

/*
функция ack(n, m)
   если n = 0
     вернуть m + 1
   иначе, если m = 0
     вернуть ack (n - 1, 1)
   еще
     вернуть ack(n - 1, ack (n, m - 1))
*/
//function
int A(int m, int n) { 
    if(m==0) { 
        return n+1;
    }
    else if(n==0) { 
        return A(m-1,1);
    } else { 
        return A(m-1,A(m,n-1));
    }
}

Console.Write("Lesson 7.2.1\n");

Console.Write("Enter natural number M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter natural number N:");
int n = Convert.ToInt32(Console.ReadLine());

if(m<=0 || n<=0)
    Console.Write("Not a natural numbers:");

Console.Write($"{A(m,n)}");
