using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marija_Homework_Class05_1__Task2.Models
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver CarDriver { get; set; }
        public int CalculateSpeed(Driver DriverCar)
        {
           return  CarDriver.Level * Speed;
        }
    }
}
