using System;
using System.Collections.Generic;
using System.Text;

namespace LR_Nasl_1
{
    public class PublicTransport : Transport
    {
        //вартість поїздки за пасажира
        public double CostPerPassenger { get; set; }
        //конструктор
        public PublicTransport(string name, double costPerPassenger) : base(name)
        {
            CostPerPassenger = costPerPassenger;
        }
        //розрахунок вартості поїздки
        public override double CalculateCost(Trip trip)
        {
            return CostPerPassenger * trip.Passengers;
        }
    }
}
