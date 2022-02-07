using CESI_POO_Ex2.Model;
using System;
using System.Threading;

namespace CESI_POO_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();

            try
            {
                stopWatch.Stop();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                stopWatch.Start();
                stopWatch.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Thread.Sleep(5000);
                stopWatch.Stop();

                stopWatch.PrintResult();
            }


            stopWatch.Start();
            Thread.Sleep(2000);
            stopWatch.Stop();


            stopWatch.Reset();
            stopWatch.Start();
            Thread.Sleep(10000);
            stopWatch.Stop();

            stopWatch.PrintResult();

            for(int i = 0; i < 2; i++)
            {
                stopWatch.Reset();

                Console.WriteLine("Press enter to start StopWatch");
                Console.ReadLine();
                stopWatch.Start();

                Console.WriteLine("Press enter to stop StopWatch");
                Console.ReadLine();
                stopWatch.Stop();

                Console.Clear();
                stopWatch.PrintResult();

            }
        }
    }
}
