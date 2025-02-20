﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Class1
    {
        public Class1()
        {
        }

        public Class1(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"This car goes {EngineNoise}");

        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"The horn goes {HonkNoise}");
        }
    }
}
