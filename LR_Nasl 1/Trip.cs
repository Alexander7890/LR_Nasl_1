using System;
using System.Collections.Generic;
using System.Text;

namespace LR_Nasl_1
{
    public class Trip
    {
        //кількість пасажирів та відстань
        public int Passengers { get; set; }
        //відстань
        public double Distance { get; set; }
        //конструктор
        public Trip(int passengers, double distance)
        {
            Passengers = passengers;
            Distance = distance;
        }
    }
}
