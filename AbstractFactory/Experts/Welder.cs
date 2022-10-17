using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactory.Interfaces;

namespace AbstractFactory.Experts
{
    public class Welder : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I can only fit iron doors");
        }
    }
}
