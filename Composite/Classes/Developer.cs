using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Composite.Interfaces;

namespace Composite.Classes
{
    internal class Developer : IEmployee
    {
        private string mName;
        private float mSalary;

        public Developer(string name, float salary)
        {
            this.mName = name;
            this.mSalary = salary;
        }

        public float GetSalary()
        {
            return this.mSalary;
        }

        public string GetRole()
        {
            return "Developer";
        }

        public string GetName()
        {
            return this.mName;
        }
    }
}
