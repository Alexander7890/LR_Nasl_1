using System;
using System.Collections.Generic;
using System.Text;

namespace LR_Nasl_1
{
    //класи для транспорту, поїздки та розрахунку вартості поїздки
    public class Transport
    {
        public string Name { get; set; }

        public Transport(string name)
        {
            Name = name;
        }
        //розрахунок вартості поїздки
        public virtual double CalculateCost(Trip trip)
        {
            return 0;
        }
    }
}
