using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legacy
{
    public class Plane: FlyingApparatus
    {
        public Gas Gas { get; set; }

        public override void ShowData()
        {
            Console.WriteLine($"Name: {Name}, Release date: {ReleaseDate}, " +
                $"Country: {Country}, Gas: {Gas}");
        }
    }
}
