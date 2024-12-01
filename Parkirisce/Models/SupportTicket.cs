using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkirisce.Models
{
    public class SupportTicket
    {
        public int Id { get; set; }
        public string PodrobnostiTezave { get; set; }
        public string Status { get; set; }

        public SupportTicket UstvariNovoZahtevo(string tezava)
        {
            return new SupportTicket
            {
                Id = new Random().Next(1, 1000),
                PodrobnostiTezave = tezava,
                Status = "Nova"
            };
        }

        public void PosodobiStatus(string status)
        {
            Status = status;
        }
    }
}
