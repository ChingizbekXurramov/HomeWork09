namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your String : ");
            string str1 = Console.ReadLine();
            Console.Write("+Input your String : ");
            string str2 = Console.ReadLine();

            for (int i = 1; i < str1.Length + str2.Length; i++)
            {
                if (i ==    str1.Length) continue;
                else Console.Write((str1 + str2)[i]);
            }

            Console.ReadLine();

        }
        
    }
}