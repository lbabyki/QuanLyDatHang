﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SoftwareProductCreator : ProductCreator
    {
        public override IDigitalProduct CreateProduct() => new SoftwareProduct();
    }
}
