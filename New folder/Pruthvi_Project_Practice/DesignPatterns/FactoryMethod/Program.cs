// See https://aka.ms/new-console-template for more information

using FactoryMethod.Factory;
using FactoryMethod.Product;

VehicleFactory vehicleFactory = new ConcreteVehicleFactory();

// BIKE
IVehicle bike =  vehicleFactory.GetVehicle("Bike");
bike.Color();
bike.Drive();
Console.WriteLine("===============================================");

// SCOOTER
IVehicle scooter = vehicleFactory.GetVehicle("Scooter");
scooter.Color();
scooter.Drive();
Console.WriteLine("===============================================");

// SPORT BIKE
IVehicle sportBike = vehicleFactory.GetVehicle("SportBike");
sportBike.Color();
sportBike.Drive();

Console.ReadKey();
