using System;
using System.Collections.Generic;
using System.Text;

namespace LR_Nasl_1
{
    public class IndividualTransport : Transport
    {
        //вартість поїздки за км
        public double CostPerKm { get; set; }
        //конструктор
        public IndividualTransport(string name, double costPerKm) : base(name)
        {
            CostPerKm = costPerKm;
        }
        //розрахунок вартості поїздки
        public override double CalculateCost(Trip trip)
        {
            return CostPerKm * trip.Distance;
        }
    }
}
