using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkirisce.Models
{
    public class Bike
    {
        public int Id { get; set; }
        public int CasVUporabi { get; set; }
        public int Kilometri { get; set; }
        public bool PotrebaPoServisu { get; set; }

        public bool PreveriStanje()
        {
            return Kilometri > 500 || CasVUporabi > 100 || PotrebaPoServisu;
        }

        public void PosodobiStanje()
        {
            PotrebaPoServisu = false;
        }
    }
}
