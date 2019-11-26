using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legacy
{
    class Program
    {
        static void Main(string[] args)
        {
            var flyingApparatus = new List<FlyingApparatus>();
            
            flyingApparatus.Add(new Plane { Name = "Plane", ReleaseDate = new DateTime(2000, 12, 2), Country = "USA", Gas = Gas.Hydrogen});
            flyingApparatus.Add(new Aerostat { Name = "Aerostat", ReleaseDate = new DateTime(1999, 8, 27), Country = "Russia", FrameType = FrameType.Hard});
            flyingApparatus.Add(new Airship { Name = "Airship", ReleaseDate = new DateTime(2003, 4, 3), Country = "Canada", PassengerCapacity = 100, TopSpeed = 1000, EnginePower = 800});
            
            foreach (var e in flyingApparatus)
                e.ShowData();

            Console.ReadLine();
        }
    }
}
