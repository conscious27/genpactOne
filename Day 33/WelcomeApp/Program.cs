// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;

Console.WriteLine("Welcome to Core Dot Net Console App");


for(int i=1;i<=100;i++){
    if(i%2==0){
        Console.WriteLine("Even Number: \t"+i);
        Thread.Sleep(500);
    }
    else{
        Console.WriteLine("Odd Number: \t"+i);
        Thread.Sleep(250);
    }
}
Console.WriteLine("End of Program");