namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number==> ");
            string input = Console.ReadLine();
            int row1;
            bool check = int.TryParse(input, out row1);

            int row = (row1 / 2) + 1;
            int row2 = (row1 / 2);

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
            for (int i = row - 1; i >= 1; i--)
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
            Console.ReadLine();
        }
    }
}