using System;
using System.IO;
using System.Text;
using System.Linq;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] GitRepositories_1a = File.ReadAllLines(@"C:\Users\Owner\Documents\GitRepositories_1a.txt");
            String[] GitRepositories_1b = File.ReadAllLines(@"C:\Users\Owner\Documents\GitRepositories_1b.txt");
            String[] GitRepositories_2a = File.ReadAllLines(@"C:\Users\Owner\Documents\GitRepositories_2a.txt");
            String[] GitRepositories_2b = File.ReadAllLines(@"C:\Users\Owner\Documents\GitRepositories_2b.txt");
            String[] GitRepositories_3a = File.ReadAllLines(@"C:\Users\Owner\Documents\GitRepositories_3a.txt");
            String[] GitRepositories_3b = File.ReadAllLines(@"C:\Users\Owner\Documents\GitRepositories_3b.txt");

            {
                Console.WriteLine("Please choose 1: ");
                Console.WriteLine("1a");
                Console.WriteLine("1b");
                Console.WriteLine("2a");
                Console.WriteLine("2b");
                Console.WriteLine("3a");
                Console.WriteLine("3b");

                string input = "";
                String[] input1 = { "" };
                String[] input2 = { "" };

                input = Console.ReadLine().ToLower();
                switch (input)

                {
                    case "1a":
                        input1 = GitRepositories_1a;
                        break;

                    case "1b":
                        input1 = GitRepositories_1b;
                        break;

                    case "2a":
                        input1 = GitRepositories_2a;
                        break;

                    case "2b":
                        input1 = GitRepositories_2b;
                        break;

                    case "3a":
                        input1 = GitRepositories_3a;
                        break;

                    case "3b":
                        input1 = GitRepositories_3b;
                        break;


                }

                Console.WriteLine("Please choose 1: ");
                Console.WriteLine("1a");
                Console.WriteLine("1b");
                Console.WriteLine("2a");
                Console.WriteLine("2b");
                Console.WriteLine("3a");
                Console.WriteLine("3b");

                input = Console.ReadLine().ToLower();
                switch (input)

                {
                    case "1a":
                        input1 = GitRepositories_1a;
                        break;

                    case "1b":
                        input1 = GitRepositories_1b;
                        break;

                    case "2a":
                        input1 = GitRepositories_2a;
                        break;

                    case "2b":
                        input1 = GitRepositories_2b;
                        break;

                    case "3a":
                        input1 = GitRepositories_3a;
                        break;

                    case "3b":
                        input1 = GitRepositories_3b;
                        break;
                }

            }
        }
    }
}
