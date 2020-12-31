using System;
using System.Collections.Generic;
using System.Text;

namespace linq_testings
{
    static class DynamicDataStore
    {
        public static List<Person> LoadWorkers()
        {
            var workers = new List<Person>();

            workers.Add(new Person("Zolee", "Amit", 2, Convert.ToDateTime("9-2-1980")));
            workers.Add(new Person("Kim", "Bering", 1, Convert.ToDateTime("5-2-1981")));
            workers.Add(new Person("Jil", "Kelly", 4, Convert.ToDateTime("12-5-1980")));
            workers.Add(new Person("Adam", "Gore", 4, Convert.ToDateTime("11-5-1980")));
            workers.Add(new Person("Jolie", "Neg", 4, Convert.ToDateTime("7-4-1983")));
            workers.Add(new Person("Jim", "Smith", 3, Convert.ToDateTime("12-5-1987")));

            return workers;
        }
    }
}
