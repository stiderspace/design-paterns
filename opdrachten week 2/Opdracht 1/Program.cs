using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TwitterDataLoader twitter = new TwitterDataLoader();
            CallDataLoader call = new CallDataLoader();
            SensorDataLoader sensor = new SensorDataLoader();

            call.Etl();
            Console.WriteLine();
            twitter.Etl();
            Console.WriteLine();
            sensor.Etl();
            Console.ReadKey();
        }
    }
}
