using Parkirisce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkirisce.ViewModels
{
    public class MaintenanceControl
    {
        public List<Bike> Bikes { get; set; } = new List<Bike>();   

        public void DodajKolo(Bike bike)
        {
            Bikes.Add(bike);
        }

        public void ServisirajKolo(int bikeId)
        {
            var bike = Bikes.FirstOrDefault(b => b.Id == bikeId);
            if (bike != null && bike.PotrebaPoServisu)
            {
                bike.PosodobiStanje();
            }
        }
    }
}
