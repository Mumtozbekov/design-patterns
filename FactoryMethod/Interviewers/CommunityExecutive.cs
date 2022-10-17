using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FactoryMethod.Interfaces;

namespace FactoryMethod.Interviewers
{
    public class CommunityExecutive : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine( "Asking about community building!");
        }
    }
}
