using System;
namespace InterfaceExercise
{
    public class Car : IVehicle,ICompany
    {
        public Car()
        {

        }
        public bool convertible { get; set; }
        public int trunkSize { get; set; }
        public string name { get;set; }
        public string logo { get;set; }
        public int numofWheels { get; set; }
        public int year { get; set; }
        public string color { get; set; }
        public string model { get; set; }
    }
}
