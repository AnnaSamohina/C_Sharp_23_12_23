using System;

//function
void printArrReverse(int[] arr,int length) { 
    if(length<0)
        return;
    Console.Write($"{arr[length]},");
    length--;
    printArrReverse(arr,length);
}

Console.Write("Lesson 7.3\n");

int[] arr = {4,6,8,9,2,0,11,6};
Console.Write("Start Array Numbers:\n");
Console.WriteLine("[{0}]", string.Join(", ", arr));
Console.Write("Result:\n");
printArrReverse(arr,arr.Length-1);
