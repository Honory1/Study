using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legacy
{
    public class Aerostat: FlyingApparatus
    {
        public FrameType FrameType { get; set; }

        public override void ShowData()
        {
            Console.WriteLine($"Name: {Name}, ReleaseDate: {ReleaseDate}, Country: {Country}, FrameType: {FrameType}");
        }
    }
}
