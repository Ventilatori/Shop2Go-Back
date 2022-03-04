﻿using MongoDB.Driver.GeoJsonObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2Go.RequestResponse
{
    public class LocationCoord
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
