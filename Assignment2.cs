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

            Console.WriteLine("Please choose 1: ");
            Console.WriteLine("1a");
            Console.WriteLine("1b");
            Console.WriteLine("2a");
            Console.WriteLine("2b");
            Console.WriteLine("3a");
            Console.WriteLine("3b");


            string input1 = Console.ReadLine();
        }
    }
}
