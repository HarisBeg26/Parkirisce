using Parkirisce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkirisce.ViewModels
{
    public class SupportControl
    {
        public List<SupportTicket> Tickets { get; set; } = new List<SupportTicket>();

        public void DodajZahtevo(SupportTicket ticket)
        {
            Tickets.Add(ticket);
        }

        public void PosodobiStatus(int id, string status)
        {
            var ticket = Tickets.FirstOrDefault(t => t.Id == id);
            if (ticket != null)
            {
                ticket.PosodobiStatus(status);
            }
        }
    }
}
