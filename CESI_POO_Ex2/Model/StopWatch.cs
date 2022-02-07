using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI_POO_Ex2.Model
{
    public class StopWatch
    {
        private DateTime? StartTime { get; set; }
        private DateTime? EndTime { get; set; }
        private bool isRunning { get; set; }
        public TimeSpan? TimeSpan { get; set; }

        public StopWatch() 
        {
            isRunning = false;
        }

        public void Start()
        {
            if (isRunning)
                throw new InvalidOperationException("StopWatch already started.");
            StartTime = DateTime.UtcNow;
            isRunning = true;
        }

        public void Stop()
        {
            if (!isRunning || !StartTime.HasValue )
                throw new InvalidOperationException("StopWatch not started.");
            EndTime = DateTime.UtcNow;
            TimeSpan = new TimeSpan(EndTime.Value.Ticks - StartTime.Value.Ticks);
            isRunning = false;
        }

        public void Reset()
        {
            StartTime = null;
            EndTime = null;
            TimeSpan = null;
            isRunning = false;
        }

        public void PrintResult()
        {
            if(TimeSpan == null)
                throw new InvalidOperationException("StopWatch has no results recorded");
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return "Start Time : " + StartTime.Value.ToString("HH:mm:ss:ffffff dd/MM/yyyy")
                + "\n" + "Stop Time : " + EndTime.Value.ToString("HH:mm:ss:ffffff dd/MM/yyyy")
                + "\n" + "Result : " + TimeSpan.Value.ToString("G");
        }
    }
}
