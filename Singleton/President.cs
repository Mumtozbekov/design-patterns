using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class President
    {
        static President instance;
        // Private constructor
        private President()
        {
            //Hiding the Constructor
        }

        // Public constructor
        public static President GetInstance()
        {
            if (instance == null)
            {
                instance = new President();
            }
            return instance;
        }
    }
}
