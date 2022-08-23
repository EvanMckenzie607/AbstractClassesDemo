using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 2020;
        public string Make { get; set; } = "Empty Make";
        public string Model { get; set; } = "Empty Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is in hyperDrive");
        }

    }
}
