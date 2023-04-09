using System.Diagnostics.Metrics;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number==> ");
            string number = Console.ReadLine();
            int row;
            bool check = int.TryParse(number, out row);

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Main(args);





            Console.ReadLine();
        }
    }
}