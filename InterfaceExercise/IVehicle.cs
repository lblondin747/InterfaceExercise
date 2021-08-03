using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int numofWheels { get; set; }
        public int year { get; set; }
        public string color { get; set; }
        public string model { get; set; }
    }
}
