using DesignPatterns.Models;
using System;

namespace DesignPatterns.FactoryMethod
{
    public static class Factory
    {
        public static Vehicle CreateVehicle(string model, string color, string brand, int year)
        {
            switch (model)
            {
                case "Mustang":
                    return new Car(color, brand, model, year);
                case "Explorer":
                    return new Car(color, brand, model, year);
                case "Escape":
                    return new Car(color, brand, model, year);
                default:
                    throw new ArgumentException("Invalid vehicle model");
            }
        }
    }
}
