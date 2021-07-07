using System;
using System.Threading;

namespace UsingThreadState
{
    class Program
    {
        private static void PrintThreadState(ThreadState state)
        {
            Console.WriteLine("{0, -16} : {1}", state, (int)state);
        }
        static void Main(string[] args)
        {
            PrintThreadState(ThreadState.Running);

            PrintThreadState(ThreadState.SuspendRequested);

            PrintThreadState(ThreadState.Background);

            PrintThreadState(ThreadState.Unstarted);

            PrintThreadState(ThreadState.Stopped);

            PrintThreadState(ThreadState.WaitSleepJoin);

            PrintThreadState(ThreadState.Suspended);

            PrintThreadState(ThreadState.AbortRequested);

            PrintThreadState(ThreadState.Aborted);

            PrintThreadState(ThreadState.Stopped | ThreadState.Aborted);

        }
    }
}
