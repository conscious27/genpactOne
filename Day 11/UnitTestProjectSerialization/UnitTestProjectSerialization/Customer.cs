﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectSerialization
{
    [Serializable]
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
