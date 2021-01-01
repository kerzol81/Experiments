using System;
using System.Collections.Generic;

namespace linq_testings
{
    static class DynamicDataStore
    {
        public static List<Person> LoadWorkers()
        {
            var workers = new List<Person>();

            workers.Add(new Person("Zolee", "Amiton", 2, Convert.ToDateTime("9-2-1980")));
            workers.Add(new Person("Kim", "Bering", 1, Convert.ToDateTime("5-2-1981")));
            workers.Add(new Person("Jil", "Kelly", 4, Convert.ToDateTime("12-5-1980")));
            workers.Add(new Person("Adam", "Gore", 4, Convert.ToDateTime("11-5-1980")));
            workers.Add(new Person("Archie", "Leach", 2, Convert.ToDateTime("11-7-1970")));
            workers.Add(new Person("Andy", "Simon", 5, Convert.ToDateTime("11-5-1979")));
            workers.Add(new Person("Chin", "Silky", 5, Convert.ToDateTime("11-5-1979")));
            workers.Add(new Person("Jolie", "Nester", 4, Convert.ToDateTime("7-4-1983")));
            workers.Add(new Person("Jim", "Smith", 3, Convert.ToDateTime("12-5-1987")));

            return workers;
        }
    }
}
