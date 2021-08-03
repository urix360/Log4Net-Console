using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ConsoleApp
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            log4net.GlobalContext.Properties["input"] = num;
            Stopwatch timer = new Stopwatch();
            int i = 0;
            for (timer.Start(); i < num; i++)
            {

            }
            timer.Stop();
            TimeSpan ts = timer.Elapsed;
            log4net.GlobalContext.Properties["time"] = ts.Milliseconds / 10.0;
            log.Error("");
            Console.ReadLine();
        }
    }
}
