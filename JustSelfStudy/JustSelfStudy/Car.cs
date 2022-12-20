using System;
using System.Collections.Generic;
using System.Text;

namespace JustSelfStudy
{
    internal class Car:Vehicle
    {
        public Car(int fuelCcapacity,string brand,string model,int year)
        {
            FuelCapacity= fuelCcapacity;    
        }

        public Car(int fuelCapacity)
        {
            FuelCapacity = fuelCapacity;
        }

        public int FuelCapacity;
        

    }
}
