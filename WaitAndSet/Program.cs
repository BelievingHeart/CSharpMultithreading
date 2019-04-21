using System;
using System.Threading;

namespace WaitAndSet
{
    class Program
    {
        private static AutoResetEvent cond = new AutoResetEvent(false);
        private static volatile bool applicationEnds = false;
        static void Main(string[] args)
        {
            new Thread(worker).Start();

            for (int i = 0; i < 5; i++)
            {
                Console.ReadLine();
                cond.Set();
            }

            applicationEnds = true;
        }


        static void worker()
        {
            while (!applicationEnds)
            {
                cond.WaitOne();
                Console.WriteLine("Sleep\r\n");
                Thread.Sleep(3000);
                Console.WriteLine("Let go of worker!\r\n");
                 
            }
        }
    }
}
