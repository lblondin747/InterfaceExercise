using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            var car1 = new Car() {year = 2009, numofWheels = 4, model = "Corvette", name = "Chevrolet", color = "red", convertible = true, logo = "cross", trunkSize = 22 };
            var truck1 = new Truck() { year = 2010, numofWheels = 4, logo = "Ram", color = "blue", bedSize = 96, model = "1500", name = "Dodge", towWeight = 10450 };
            var suv1 = new SUV() { year = 2020, numofWheels = 4, name = "Kia", model = "Telluride", color = "white", cargoHoldSize = 21, logo = "oval", thirdRow = true };

            //Creatively display and organize their values
            Console.WriteLine($"My {car1.year} {car1.name} {car1.model} is a {car1.numofWheels} wheeled car with {car1.trunkSize} cubic ft of trunk size.");
            Console.WriteLine($"The logo looks like a {car1.logo}, and the color is {car1.color}.");
            Console.WriteLine((car1.convertible) ? $"My {car1.model} is a convertible" : $"My {car1.model} isn't a convertible");


            Console.WriteLine();
            Console.WriteLine($"My {truck1.year} {truck1.name} {truck1.logo} {truck1.model} is a {truck1.color} {truck1.numofWheels} wheeled truck. ");
            Console.WriteLine($"It can tow up to {truck1.towWeight} pounds, and has a {truck1.bedSize} inch long bed.");

            Console.WriteLine();
            Console.WriteLine($"My moms {suv1.year} {suv1.name} {suv1.model} is {suv1.color} and has {suv1.numofWheels} wheels.");
            Console.WriteLine($"The logo looks like an {suv1.logo} and the cargo size is {suv1.cargoHoldSize} cubic ft.");
            Console.WriteLine((suv1.thirdRow) ? $"Her {suv1.model} has a third row" : $"Her {suv1.model} doesn't have a third row");

        }
    }
}
