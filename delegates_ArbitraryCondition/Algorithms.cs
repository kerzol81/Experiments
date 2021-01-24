using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace delegates_ArbitraryCondition
{
    delegate bool ArbitraryCondition(int i);
    static class Algorithms
    {
        public static bool Search(List<int> array, ArbitraryCondition condition)
        {
            return true;
            //return array.Any(x => x is condition);
        }

        
    }
}
