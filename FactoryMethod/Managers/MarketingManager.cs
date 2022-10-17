using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FactoryMethod.Interfaces;
using FactoryMethod.Interviewers;
using FactoryMethod.Menagers;

namespace FactoryMethod.Managers
{
    public class MarketingManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new CommunityExecutive();
        }
    }
}
