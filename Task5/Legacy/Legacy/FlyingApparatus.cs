using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legacy
{
    public class FlyingApparatus 
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Country { get; set; }

        public virtual void ShowData()
        {
            Console.WriteLine($"Name: {Name}, ReleaseDate: {ReleaseDate}, Country: {Country}");
        }
    }
}
