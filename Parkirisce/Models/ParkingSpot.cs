using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkirisce.Models
{
    public class ParkingSpot
    {
        public string Lokacija { get; set; }
        public int Stevilka { get; set; }
        public string Tip { get; set; }

        public bool ValidirajPodatke()
        {
            return !string.IsNullOrEmpty(Lokacija) && Stevilka > 0 && !string.IsNullOrEmpty(Tip);
        }
    }
}
