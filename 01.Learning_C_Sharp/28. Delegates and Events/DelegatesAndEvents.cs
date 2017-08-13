namespace Delegates_and_Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DelegatesAndEvents
    {

        //Delegate:
        public delegate void WorkPerformedHandler(int hours, WorkType workType);

        public delegate int AddHandler(int a, int b);

        public static void Main()
        {
            //Instance:
            WorkPerformedHandler dele = new WorkPerformedHandler(WorkPerformed);

            //Invoke:
            dele(10, WorkType.Meetings);

            //Add to the invocation list:
            WorkPerformedHandler first = new WorkPerformedHandler(WorkPerformed);
            WorkPerformedHandler second = new WorkPerformedHandler(WorkPerformedSecond);
            first = first + second;    //Можем да добавим лист от делегати, които се извикват последователно.
            first(5, WorkType.Golf);

            //Lambda expressions can be assigned to any delegate:
            AddHandler ab = (a, b) => a + b;
            int result = ab(1, 1);  //  2            
        }

        //Handler:
        public static void WorkPerformed(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed called {workType} for {hours} hours");
        }

        public static void WorkPerformedSecond(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformedSecond called {workType} for {hours} hours");
        }
    }

    public enum WorkType
    {
        Meetings,
        Sport,
        Exam,
        Golf
    }

    public class Worker
    {
        public delegate void WorkPerfHandler(int hours, WorkType workType);

        public event WorkPerfHandler WorkPerformed;

        public virtual void DoWork(int hours, WorkType workType)
        {
            // Do work here and notify consumer that work has been performed           
            OnWorkPerformed(hours, workType);
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            WorkPerfHandler del = WorkPerformed as WorkPerfHandler;

            if (del != null) //Listeners are attached         
            {
                del(hours, workType);
            }
        }
    }
}
