using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marija_Homework_Class05_1__Task1.Models
{
    internal class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string GetPersonDetails()
        {
            return $"{FirstName} {LastName} - {Age}";
        }
        public Human(string firstName, string secondName, int age)
        {
            FirstName = firstName;
            LastName = secondName;
            Age = age;
        }
    }
}
