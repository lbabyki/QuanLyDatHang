﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SoftwareProduct : IDigitalProduct
    {
        public void Deliver() => Console.WriteLine("Delivering software...");
    }
}
