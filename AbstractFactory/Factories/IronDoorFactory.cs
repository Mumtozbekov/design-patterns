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
    public class IronDoorFactory : IDoorFactory
    {
        public IDoor MakeDoor()
        {
            return new IronDoor();
        }

        public IDoorFittingExpert MakeFittingExpert()
        {
            return new Welder();
        }
    }
}
