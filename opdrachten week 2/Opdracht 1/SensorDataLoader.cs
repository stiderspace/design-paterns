﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    public class SensorDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("extracting sensor data...");
        }

        public override void Load()
        {
            Console.WriteLine("loading sensor data...");
        }

        public override void Transform()
        {
            Console.WriteLine("transforming sensor data...");
        }
    }
}
