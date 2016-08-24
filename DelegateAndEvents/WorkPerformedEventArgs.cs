using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public WorkPerformedEventArgs(int hours, WorkType worktype)
        {
            Hours = hours;
            WorkType = worktype;
        }

        public int Hours { get; private set; }
        public WorkType WorkType { get; private set; }
    }
}
