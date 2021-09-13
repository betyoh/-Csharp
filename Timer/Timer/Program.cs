using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;


namespace Timer___
{
    class Program
    {
        private static Timer _timer;
        private static int _count;
        static void SetTimer()
        {
            _timer = new Timer(1000);
            _count = 0;
            _timer.Elapsed += TimerOnElapsed;
            _timer.AutoReset = true;
            _timer.Enabled = true;


        }

        private static void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            _count++;
            Console.WriteLine($" Timer event rase at {e.SignalTime}    Event Count : {_count}");
        }
        static void Main(string[] args)
        {
            SetTimer();
            Console.WriteLine($"Press any key to exit");
            Console.WriteLine($"application startet at {DateTime.UtcNow:F}");
            Console.ReadLine();
            if (_timer != null)
            {
                _timer.Stop();
                _timer.Dispose();
            }
            Console.WriteLine("Timer terminating.....");

        }



    }
}

