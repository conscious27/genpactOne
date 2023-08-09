using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Program
    {
        public delegate void Sorting(int[] arr);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count of numbers: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the Number {0}",i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Sorting sort = delegate (int[] array)
            {
                for(int i=0; i<array.Length; i++)
                {
                    int min = i;
                    for(int j=i+1; j<array.Length; j++)
                    {
                        if (array[j] < arr[min])
                        {
                            min = j;
                        }
                    }

                    int temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                }
            };

            sort(arr);
            Console.WriteLine("Array after sorting: ");
            for(int i=0; i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
