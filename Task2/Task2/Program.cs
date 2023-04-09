using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number==> ");
            string number = Console.ReadLine();
            int array;
            bool check = int.TryParse(input, out array);
            int[] arr = new int[array];


            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int k = random.Next(1, 10);
                Console.Write(k + " ");
                arr[i] = k;
            }
            Console.WriteLine();


            Array.Sort(arr);

            Console.WriteLine("Sort array : ");

            foreach (int num in arr)
            {
                Console.Write(num + ", ");
            }

            Console.ReadLine();
        }
    }
}