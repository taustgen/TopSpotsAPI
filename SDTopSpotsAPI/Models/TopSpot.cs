﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDTopSpotsAPI.Models
{
    public class TopSpot
    {
        public string Name { get; set; }
        public double[] Location { get; set; }
        public string Description { get; set; }
    }
}