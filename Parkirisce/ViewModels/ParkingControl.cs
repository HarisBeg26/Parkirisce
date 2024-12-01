using Parkirisce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkirisce.ViewModels
{
    public class ParkingControl
    {
        public List<ParkingSpot> ParkingSpots { get; set; } = new List<ParkingSpot>();

        public void DodajParkirnoMesto(ParkingSpot spot)
        {
            if (spot.ValidirajPodatke())
            {
                ParkingSpots.Add(spot);
            }
            else
            {
                throw new Exception("Podatki parkirnega mesta niso veljavni!");
            }
        }
    }
}
