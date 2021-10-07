using System;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public static class StuffToTest
    {
        public static void addSomthing(ref int x)
        {
            ++x;
        }
    }
}
