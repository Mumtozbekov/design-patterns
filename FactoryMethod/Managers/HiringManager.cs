using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FactoryMethod.Interfaces;

namespace FactoryMethod.Menagers
{
    public abstract class HiringManager
    {
        abstract protected IInterviewer MakeInterviewer();
        public void TakeInterview()
        {
            var interviewer = this.MakeInterviewer();
            interviewer.AskQuestions();
        }
    }
}
