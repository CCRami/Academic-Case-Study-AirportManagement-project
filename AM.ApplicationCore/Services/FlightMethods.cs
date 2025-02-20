using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domaine;
using AM.ApplicationCore.Domaines;
using AM.ApplicationCore.Interfaces;

namespace AM.ApplicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights =new List<Flight>();



        //public List<DateTime> GetFlightDates(string destination)
        //{
        //normal
        //    List<DateTime> listofdates = new List<DateTime>();
        //    for (int i = 0; i < Flights.Count; i++) {
        //        if (Flights[i].Destination==destination)
        //            listofdates.Add(Flights[i].FlightDate);
        //    }
        //    return listofdates;
        //}
        //public List<DateTime> GetFlightDates(string destination)
        //{
        //linq
        //    List<DateTime> listofdates = new List<DateTime>();
        //    var query = from f in Flights
        //                where f.Destination == destination
        //                select f.FlightDate;

        //    return query.ToList();
        //}
        public List<DateTime> GetFlightDates(string destination)
        {
            //lambda
            return Flights.Where(f => f.Destination == destination).Select(f => f.FlightDate).ToList();
        }
        public List<DateTime> GetFlightDateswithForEach(string destination)
        {
            //List<DateTime> listofdates = new List<DateTime>();
            //foreach (Flight flight in Flights)
            //{
            //    if (flight.Destination == destination)
            //        listofdates.Add(flight.FlightDate);
            //}
            //return listofdates;
            return Flights.Where(f => f.Destination == destination).Select(f => f.FlightDate).ToList();
        }
        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Departure":
                    for(int i = 0;i<Flights.Count;i++)
                    {
                        if (Flights[i].Departure == filterValue)
                            Console.WriteLine(Flights[i]);
                    }
                    break;
                case "Destination":
                    for (int i = 0; i < Flights.Count; i++)
                    {
                        if (Flights[i].Destination == filterValue)
                            Console.WriteLine(Flights[i]);
                    }
                    break;
                case "EffectiveArrival":
                    for (int i = 0; i < Flights.Count; i++)
                    {
                        if (Flights[i].EffectiveArrival.ToString() == filterValue)
                            Console.WriteLine(Flights[i]);
                    }
                    break;
                case "EstimatedDuration":
                    for (int i = 0; i < Flights.Count; i++)
                    {
                        if (Flights[i].EstimatedDuration.ToString() == filterValue)
                            Console.WriteLine(Flights[i]);
                    }
                    break;
                case "FlightDate":
                    for (int i = 0; i < Flights.Count; i++)
                    {
                        if (Flights[i].FlightDate.ToString() == filterValue)
                            Console.WriteLine(Flights[i]);
                    }
                    break;

            }
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            //return (from f in Flights
            //          where DateTime.Compare(startDate,f.FlightDate) <=0 && DateTime.Compare(f.FlightDate,startDate.AddDays(7)) <=0
            //          select f).Count();
            return Flights.Where(f => DateTime.Compare(startDate, f.FlightDate) <= 0 && DateTime.Compare(f.FlightDate, startDate.AddDays(7)) <= 0).Count();
        }

        public void ShowFlightDetails(Domaine.Plane plane)
        {
            //var req = from f in Flights
            //          where f.Plane == plane
            //          //select f.Destination + " " + f.Departure;
            //          select new { f.Destination, f.FlightDate };
            //foreach (var item in req)
            //{
            //    Console.WriteLine("Destination: "+item.Destination + " | FlightDate: " + item.FlightDate);
            //}
            //lambda
            Flights.Where(f => f.Plane == plane).ToList().ForEach(f => Console.WriteLine("Destination: " + f.Destination + " | FlightDate: " + f.FlightDate));
        }
        public double DurationAverage(string destination)
        {
            //var query = from f in Flights
            //            where f.Destination == destination
            //            select f.EstimatedDuration;
            //return query.Average();
            return Flights.Where(f => f.Destination == destination).Select(f => f.EstimatedDuration).Average();
        }

        public IEnumerable<Flight> OrderedDurationFlights()
        {
            //var query = from f in Flights
            //            orderby f.EstimatedDuration descending
            //            select f;
            //return query;
            return Flights.OrderByDescending(f => f.EstimatedDuration);
        }
        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            //var query = from p in flight.Passengers.OfType<Traveller>()
            //            orderby p.BirthDate
            //            select p;
            //return query.Take(3);
            return flight.Passengers.OfType<Traveller>().OrderBy(p => p.BirthDate).Take(3);
        }

        public void DestinationGroupedFlights()
        {
            //IEnumerable<IGrouping<string, Flight>> query = from f in Flights
            //                                               group f by f.Destination;
            //foreach (IGrouping<string, Flight> group in query)
            //{
            //    Console.WriteLine("Destination: " + group.Key);
            //    foreach (Flight f in group)
            //    {
            //        Console.WriteLine("Décollage:  " + f.FlightDate);
            //    }

            //}



            var query = Flights.GroupBy(f => f.Destination);
            foreach (var group in query)
            {
                Console.WriteLine("Destination: " + group.Key);
                foreach (var f in group)
                {
                    Console.WriteLine("Décollage:  " + f.FlightDate);
                }
            }
        }
    }
}
