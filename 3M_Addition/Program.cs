using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3M_Addition
{
    class Program
    {
        private static int count = 0;
        private static object mu_count = new object();
        static void Main(string[] args)
        {
            var t1 = new Thread(addOneMillion);
            var t2 = new Thread(addOneMillion);
            var t3 = new Thread(addOneMillion);
            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine(count.ToString());

        }





        private static void addOne()
        {
//            lock (mu_count)
//            {
//                count++;
//            }
            count++;


        }

        private static void addOneMillion()
        {
            for (int i = 0; i < 1000000; i++)
            {
                addOne();
            }
        }


    }
}
