using System;

namespace MoviesDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection.GetConnection();

            Console.ReadKey();
        }
    }
}