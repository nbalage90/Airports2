﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Airports.Logic.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ThreeLetterISOCode { get; set; }
        public string TwoLetterISOCode { get; set; }
    }
}
