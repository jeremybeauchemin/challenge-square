using System;
namespace challenge
{
    public class square
    {
        public static int Height = 20;

        static void Main(string[] args)
        {
            Console.Write("Enter Height :");
            Height = int.Parse(Console.ReadLine());

            Console.Write(" Method 1: " + "\n Method 2: " + "\n Method 3: " + "\n LEAVE 4: ");
            var no = Console.ReadLine();
            var leave = 4;
            if (no == "1")
            {
                Method1();
            }
            else if (no == "2")
            {
                Method2();
            }
            else if (no == "3")
            {
                Method3();
            }
            else if (no == "leave")
            {
                Environment.Exit(4);
            }
            else
            {
                Console.WriteLine("you can jsute enter number dumbass");
            }
            Console.WriteLine();
        }
        private static void Method1()
        {
            for (int i = 0; i <= Height; i++)
            {
                for (int l = 0; l <= Height; l++)
                {
                    if (i == 0 || i == Height || l == 0 || l == Height)

                        Console.Write('*');
                    else
                        Console.Write('-');
                }
                Console.WriteLine();
            }
        }
        private static void Method2()
        {
            for (int i = 0; i <= Height; i++)
            {
                for (int l = 0; l <= Height; l++)
                {
                    if (i == 0 || i == Height || l == 0 || l == Height || i == l || l == Height)

                        Console.Write('*');
                    else
                        Console.Write('-');
                }
                Console.WriteLine();
            }
        }
        private static void Method3()
        {
            for (int i = 0; i <= Height; i++)
            {
                for (int l = 0; l <= Height; l++)
                {
                    if (i == 0 || i == Height || l == 0 || l == Height || i == l || l == (Height - i))

                        Console.Write('*');
                    else
                        Console.Write('-');
                }
                Console.WriteLine();
            }
        }
    }
}
