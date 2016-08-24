using System;

namespace DelegateAndEvents
{

    public delegate int WorkerPerformedHandler(int hours, WorkType worktype);
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
//            DoWork(worker.DoWork(3, WorkType.GoToMeetings));
            
/*          WorkerPerformedHandler delegate1 = new WorkerPerformedHandler(WorkerPerformed1);
          WorkerPerformedHandler delegate2 = new WorkerPerformedHandler(WorkerPerformed2);
          WorkerPerformedHandler delegate3 = new WorkerPerformedHandler(WorkerPerformed3);

          delegate1 += delegate2 + delegate3;

          int finalHours = delegate1(7,WorkType.GoToMeetings);
          Console.WriteLine("Final Hours {0}", finalHours.ToString());
*/
          Console.Read();
        }

        static void DoWork(WorkerPerformedHandler del)
        {
            del(5, WorkType.Read);
        }


        static int WorkerPerformed1(int hours, WorkType worktype)
        {
            Console.WriteLine("WorkerPerformed 1 called - Hours {0} ",hours.ToString());
            return hours + 1;
        }

        static int WorkerPerformed2(int hours, WorkType worktype)
        {
            Console.WriteLine("WorkerPerformed 2 called - Hours {0} ", hours.ToString());
            return hours + 2;
        }

        static int WorkerPerformed3(int hours, WorkType worktype)
        {
            Console.WriteLine("WorkerPerformed 3 called - Hours {0} ", hours.ToString());
            return hours + 3;
        }

    }
}
