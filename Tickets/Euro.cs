using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    public class Euro : Ticket  // Euro is a subclass of the base class Ticket
    {
        public int[] LuckyStar { get; set; } = new int[2];
        public string Country { get; set; }

        public override string ToString() // This overrides the ToString() class in Ticket.
        {
            string message;
            StringBuilder sb = new StringBuilder();

            sb.Append(customer.Name);
            sb.Append(customer.Email);
            sb.Append(day);
            sb.Append(Numbers[1]);
            sb.Append(Country);
            message = sb.ToString();

            return message;

        }
    }
}
