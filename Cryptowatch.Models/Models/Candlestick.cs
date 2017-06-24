﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptowatch.Models
{
    public class Candlestick
    {
        public DateTime Date { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
        public double QuoteVolume { get; set; }
        public double WeightedAverage { get; set; }


        public double SMA10 { get; set; }
        public double SMA20 { get; set; }
        public double UpperBand { get; set; }
        public double LowerBand { get; set; }
    }
}