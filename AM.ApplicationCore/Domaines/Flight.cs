﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domaine;

namespace AM.ApplicationCore.Domaines
{
    public class Flight
    {
        public string Departure { get; set; }
        public string Destination { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime FlightDate {  get; set; }
        public int FlightId {  get; set; }
        //propriéttés de Naviguation
        public Plane Plane { get; set; }
        public ICollection<Passenger> Passengers {  get; set; }
        public override string ToString()
        {
            return "Departure: " + Departure + " | Destination: " + Destination + " | EffectiveArrival: " + EffectiveArrival + " | EstimatedDuration: " + EstimatedDuration + " | FlightDate: " + FlightDate;

        }
    }
}
