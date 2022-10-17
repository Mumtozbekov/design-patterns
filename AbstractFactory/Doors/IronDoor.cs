using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactory.Interfaces;

namespace AbstractFactory.Doors
{
    public class IronDoor : IDoor
    {
        public void GetDescription()
        {
            Console.WriteLine("I am a iron door");
        }
    }
}
