using System;

namespace ArcadisPipeline
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool IsAdultAge(int age)
        {
            return age > 17 ? true : false; 
        }
    }
}
