using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactory.Interfaces;

namespace AbstractFactory.Experts
{
    public class Carpenter : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I can only fit wooden doors");
        }
    }
}
