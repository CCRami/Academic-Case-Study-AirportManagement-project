# Airline Management System

This project is an Airline Management System built using .NET 8. It includes functionalities to manage flights, planes, passengers, and staff.

## Features

- Manage flights, including details such as departure, destination, flight date, and duration.
- Manage planes with properties like capacity, manufacture date, and type.
- Manage passengers and staff.
- Various flight-related operations such as getting flight dates, showing flight details, calculating average duration, and more.

## Installation

1. Clone the repository:
   ```sh
   git clone https://github.com/your-repo/airline-management-system.git
   ```
2. Navigate to the project directory:
   ```sh
   cd airline-management-system
   ```
3. Open the solution file in Visual Studio 2022:
   ```sh
   AirlineManagementSystem.sln
   ```
4. Build the solution to restore the dependencies and compile the project.

## Usage

1. Run the application:
    - Set `AM.UI.Console` as the startup project.
    - Press `F5` to start debugging or `Ctrl+F5` to run without debugging.

2. The console application will execute the code in `Program.cs`, demonstrating various functionalities of the system.

## Project Structure

- `AM.ApplicationCore`: Contains the core domain models and service interfaces.
  - `Domaines`: Contains domain models such as `Flight`, `Plane`, `Passenger`, `Staff`, etc.
  - `Services`: Contains service implementations like `FlightMethods`.
  - `Interfaces`: Contains service interfaces like `IFlightMethods`.

- `AM.Infrastructure`: Contains the infrastructure-related code, including database context and migrations.
  - `Migrations`: Contains Entity Framework Core migrations.

- `AM.UI.Console`: Contains the console application to interact with the system.

## Examples

### Adding a New Flight

```csharp
Flight newFlight = new Flight 
{ 
    Departure = "New York", 
    Destination = "London", 
    FlightDate = DateTime.Now.AddDays(10), 
    EstimatedDuration = 420, 
    Plane = new Plane 
    { 
        PlaneId = 1, 
        Capacity = 200, 
        ManufactureDate = DateTime.Now.AddYears(-5), 
        PlaneType = PlaneType.Boeing 
    } 
};
flightMethods.Flights.Add(newFlight);
```

### Getting Flight Dates for a Destination

```csharp
List<DateTime> flightDates = flightMethods.GetFlightDates("Paris");
Console.WriteLine(string.Join(", ", flightDates));
```

## License

This project is free to use and not under any license.
