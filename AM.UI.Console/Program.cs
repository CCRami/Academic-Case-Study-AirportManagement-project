// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domaine;
using AM.ApplicationCore.Domaines;
using AM.ApplicationCore.Services;

//Console.WriteLine("Hello, World!");
Plane p=new Plane();
//Console.WriteLine(p.ToString());
Passenger passenger = new Passenger
{
    FirstName = "rami",
    LastName = "tabib",
    EmailAddress = "**.**@esprit.tn"
};
//Console.WriteLine(passenger.CheckProfileReplacemenet("Tabib", "Rami", "**.**@esprit.tn"));
Staff staff = new Staff { };
Traveller tr = new Traveller { };
//passenger.PassengerType();
//staff.PassengerType();
//tr.PassengerType();
FlightMethods f = new FlightMethods();
f.Flights = TestData.listFlights;
//Console.WriteLine(string.Join(" , ",f.GetFlightDateswithForEach("Paris")));
//f.GetFlights("Destination", "Paris");
//f.ShowFlightDetails(TestData.BoingPlane);
//Console.WriteLine(f.ProgrammedFlightNumber(TestData.flight4.FlightDate));
//Console.WriteLine(f.DurationAverage("Paris"));
//foreach(Flight flight in f.OrderedDurationFlights())
//{
//    Console.WriteLine(flight);
//}
//foreach (Passenger pass in f.SeniorTravellers(TestData.flight1))
//{
//    Console.WriteLine(pass.BirthDate);
//}
//f.DestinationGroupedFlights();
passenger.UpperFullName();
System.Console.WriteLine(passenger.FirstName+" "+passenger.LastName);