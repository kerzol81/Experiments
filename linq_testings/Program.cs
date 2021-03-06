﻿using Serilog;
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
            //ordered = ordered.OrderByDescending(x => x.FirstName).Where(x => x.BirthDay.Year > 1980).ToList();
            ordered = ordered.Where(x => x.Experience > 2 && x.BirthDay.Year > 1979).OrderByDescending(x => x.FirstName).ToList();
            //int totalExperience = ordered.Sum(x => x.Experience);

            Log.Logger = new LoggerConfiguration().WriteTo.File(@"log.txt", rollingInterval: RollingInterval.Month).CreateLogger();

            //Log.Information(totalExperience.ToString());

            foreach (var item in ordered)
            {
                Log.Information($"{item.FullName}\tExperience:{item.Experience}\tBirthday: {item.BirthDay}");
            }
            Log.Information("".ToString());
        }
    }
}
