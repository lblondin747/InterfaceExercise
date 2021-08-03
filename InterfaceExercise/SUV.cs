using System;
namespace InterfaceExercise
{
    public class SUV : ICompany,IVehicle
    {
        public SUV()
        {
        }
        public bool thirdRow { get; set; }
        public int cargoHoldSize { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
        public int numofWheels { get; set; }
        public int year { get; set; }
        public string color { get; set; }
        public string model { get; set; }
    }
}
