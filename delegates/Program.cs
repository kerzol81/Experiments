using System;

namespace delegates
{
    delegate int Operations(int a, int b);      // declared a variable TYPE
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Operations d = Multiply;

            var answer = d(10, 20);

            Console.WriteLine(answer);

            Console.ReadKey();
        }
    }
}
