using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactory.Doors;
using AbstractFactory.Experts;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class WoodenDoorFactory : IDoorFactory
    {
        public IDoor MakeDoor()
        {
            return new WoodenDoor();
        }

        public IDoorFittingExpert MakeFittingExpert()
        {
            return new Carpenter();
        }
    }
}
