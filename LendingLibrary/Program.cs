using System;

namespace LendingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lending Library");
        }
    }

    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }
    }
}
