using System;
namespace InterfaceExercise
{
    public class Truck : ICompany,IVehicle
    {
        public Truck()
        {
        }
        public int towWeight { get; set; }
        public int bedSize { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
        public int numofWheels { get; set; }
        public int year { get; set; }
        public string color { get; set; }
        public string model { get; set; }
    }
}
