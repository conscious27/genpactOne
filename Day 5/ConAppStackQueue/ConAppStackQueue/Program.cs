using System;
using System.Collections;

namespace ConAppStackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack stack = new Stack();
            //stack.Push("Raj");
            //stack.Push("Amit");
            //stack.Push("Ravi");

            //Console.WriteLine("Number of Items in stack are: " + stack.Count);
            //foreach ( var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //stack.Pop();
            //Console.WriteLine("Number of Items in stack are: " + stack.Count);

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Peek Example: \t" +stack.Peek());

            Queue queue = new Queue();
            queue.Enqueue("Raj");
            queue.Enqueue("Amit");
            queue.Enqueue("Ravi");

            Console.WriteLine("Number of Items in Queue: \t"+queue.Count);
            Console.WriteLine("Stored Value in Queue: ");
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Dequeue();
            Console.WriteLine("After Dequeuing and Item: ");
            Console.WriteLine("Number of Items in Queue: \t" + queue.Count);
            Console.WriteLine("Stored Value in Queue: ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Peek Example: \t"+queue.Peek());
            Console.WriteLine("Number of Item in Queue: \t"+queue.Count);
            Console.ReadKey();
        }
    }
}
