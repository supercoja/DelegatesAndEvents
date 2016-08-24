using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{

    public delegate void WorkerPerformedHandler(int hours, WorkType worktpe);
    class Program
    {
        static void Main(string[] args)
        {
            WorkerPerformedHandler delegate1 = new WorkerPerformedHandler(WorkerPerformed1);
            WorkerPerformedHandler delegate2 = new WorkerPerformedHandler(WorkerPerformed2);

            DoWork(delegate2);

            Console.Read();
        }

        static void DoWork(WorkerPerformedHandler del)
        {
            del(5, WorkType.Read);
        }


        static void WorkerPerformed1(int hours, WorkType worktype)
        {
            Console.WriteLine("WorkePerformed 1 called - Hours {0} ",hours.ToString());
        }

        static void WorkerPerformed2(int hours, WorkType worktype)
        {
            Console.WriteLine("WorkePerformed 2 called - Hours {0} ", hours.ToString());
        }
    }
}
