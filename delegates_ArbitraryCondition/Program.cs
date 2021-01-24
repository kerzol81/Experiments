using System;
using System.Collections.Generic;

namespace delegates_ArbitraryCondition
{
    class Program
    {
        bool GreaterThenTen(int i)
        {
            return i > 10;
        }
        static void Main(string[] args)
        {
            var v = new List<int>();
            v.Add(1);
            v.Add(3);
            v.Add(4);
            v.Add(11);
            v.Add(6);

            //var answer = Algorithms.Search(v, GreaterThenTen);
            //Console.WriteLine(answer);

        }
    }
}
