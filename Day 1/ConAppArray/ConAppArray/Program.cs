using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConAppArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Single Dimensional Array Example
            //int[] marks = new int[5];

            //// taking marks in array
            //for(int i=0; i<marks.Length; i++)
            //{
            //    Console.WriteLine($"Enter ther marks for Subject {i+1}:");
            //    marks[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Stored Arrays are as follows: ");
            //// Priting Array
            //for(int i=0; i<marks.Length ; i++)
            //{
            //    Console.WriteLine($"Subject{i + 1}'s Marks = {marks[i]}");
            //}
            //Console.ReadKey();

            // 1-D array Second example
            //int nos;
            //Console.WriteLine("Enter number of Students: ");
            //nos = int.Parse(Console.ReadLine());
            //string[] student = new string[nos];

            //for (int i=0; i<nos; i++)
            //{
            //    Console.WriteLine($"Enter Student {i+1}'s name:");
            //    student[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Students name as follows:");
            //foreach(string stud in student)
            //{
            //    Console.WriteLine(stud);
            //}
            //Console.ReadKey();


            ////2-D array example || Reactange Array Example
            //string[,] rectArray = new string[4, 3];

            //for (int r = 0; r < 4; r++)
            //{
            //    for (int c = 0; c < 3; c++)
            //    {
            //        rectArray[r, c] = "[" + r + ","+ c + "]";
            //    }
            //}

            //for (int r=0; r < 4; r++)
            //{
            //    for (int c = 0;c < 3; c++)
            //    {
            //        Console.Write(rectArray[r, c]);
            //    }
            //    Console.WriteLine("\n");
            //}
            //Console.ReadKey();

            // Exercise 
            //int nos;
            //Console.WriteLine("Enter the number of students: ");
            //nos = int.Parse(Console.ReadLine());

            //int[,] marks = new int[nos,3];
            //for (int r=0; r<nos; r++)
            //{
            //    for (int c=0; c<3; c++)
            //    {
            //        if (c == 0)
            //        {
            //            Console.WriteLine("Enter Roll No.");
            //            marks[r, c] = int.Parse(Console.ReadLine());
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Enter Semester {c}'s marks:");
            //            marks[r, c] = int.Parse(Console.ReadLine());
            //        }
            //    }
            //}

            //Console.WriteLine("Roll No. \t" + "Mark1 \t\t" + "Marks2");
            //for (int r=0; r<nos;r++) 
            //{ 
            //    for (int c=0; c<3;c++)
            //    {
            //        Console.Write(marks[r, c] + "\t\t");
            //    }
            //    Console.WriteLine("\n");
            //}
            //Console.ReadKey();

            //// Jagged Array

            //int[][] myjArray = new int[3][];
            //myjArray[0] = new int[3] {10, 12, 14};
            //myjArray[1] = new int[2] { 15, 20 };
            //myjArray[2] = new int[5] { 5, 25, 30, 31, 34 };

            //Console.WriteLine("Stored Value in Jagged Array are: ");

            //for(int i=0; i<myjArray.Length; i++)
            //{
            //    for (int j=0; j < myjArray[i].Length; j++)
            //    {
            //        Console.Write(myjArray[i][j] + "\t");
            //    }
            //    Console.WriteLine("\n");
            //}
            //Console.ReadKey();

            // Jagged Arrray Example 2

            int noc;
            int nos;

            Console.WriteLine("Enter Number of Classes:");
            noc = int.Parse(Console.ReadLine());

            string[][] students = new string[noc][];

            for(int i=0; i<noc; i++)
            {
                Console.WriteLine($"Enter number of Student for class {i + 1}:");
                nos = int.Parse(Console.ReadLine());
                students[i] = new string[nos];

                for(int j=0; j<nos; j++)
                {
                    Console.WriteLine($"Enter Student{j+1}'s name for class {i+1}:");
                    students[i][j] = Console.ReadLine();
                }

            }

            for(int i=0; i<students.Length;i++)
            {
                Console.WriteLine($"List of Class {i+1}'s students as follows:");
                for(int j=0; j < students[i].Length; j++)
                {
                    Console.WriteLine($"Student {j+1} =\t " + students[i][j]);
                }

                Console.WriteLine("*****************************************************");
            }
            Console.ReadKey();
        }
    }
}
