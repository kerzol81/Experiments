using System;
using System.Collections.Generic;
using System.Text;

namespace linq_testings
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Experience { get; set; }
        public DateTime BirthDay { get; set; }
        public string FullName { 
            get 
            {
                return $"{FirstName} {LastName}";   
            }  
        }

        public Person(string firstName, string lastName, int experience, DateTime birthDay)
        {
            FirstName = firstName;
            LastName = lastName;
            Experience = experience;
            BirthDay = birthDay;
        }
    }
}
