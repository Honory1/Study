using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legacy
{
    public class Airship: FlyingApparatus
    {
        public double TopSpeed { get; set; }
        public double EnginePower { get; set; }
        public int PassengerCapacity { get; set; }

        public override void ShowData()
        {
            Console.WriteLine($"Name: {Name}, ReleaseDate: {ReleaseDate}, Country: {Country}, " +
                $"TopSpeed: {TopSpeed}, EnginePower: {EnginePower}, PassengerCapacity: {PassengerCapacity}");
        }
    }
}
