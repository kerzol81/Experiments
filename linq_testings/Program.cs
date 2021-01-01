using System;
using System.Linq;

namespace linq_testings
{
    class Program
    {
        static void Main(string[] args)
        {
            var ordered = DynamicDataStore.LoadWorkers();

            //ordered = ordered.OrderBy(x => x.Experience).ToList();
            //ordered = ordered.OrderByDescending(x => x.BirthDay).ToList();
            //ordered = ordered.OrderBy(x => x.Experience).ThenBy(x => x.FirstName).ToList();
            //ordered = ordered.Where(x => x.Experience > 2).ToList();
            //ordered = ordered.Where(x => x.BirthDay > Convert.ToDateTime("1-1-1984")).ToList();
            //ordered = ordered.Where(x => x.BirthDay.Year > 1984).ToList();
            ordered = ordered.OrderByDescending(x => x.FirstName).Where(x => x.BirthDay.Year > 1980).ToList();

            foreach (var item in ordered)
            {
                Console.WriteLine($"{item.FullName}\tExperience:{item.Experience}\tBirthday: {item.BirthDay}");
            }
        }
    }
}
