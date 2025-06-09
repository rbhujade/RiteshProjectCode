// See https://aka.ms/new-console-template for more information

using Decorator;

IVehicle hondaCity = new HondaCity();
Console.WriteLine("Honda City base price are : {0}", hondaCity.Price);

SpecialOffer offer = new SpecialOffer(hondaCity);
offer.DiscountPercentage = 25;
offer.Offer = "25% discount";

Console.WriteLine("{1} @ Diwali Special Offer and price are : {0} ", offer.Price, offer.Offer);

Console.ReadKey();