using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    public class LottoT : Ticket
    {
        private int _bonusBall;  // backing variable for BonusBall property
        public int BonusBall    // property with logic applied, adhering to encapsulation
        {
            // ensure the twitter address starts with an @
            get { return _bonusBall; }
            set
            {
                if (value > 0 && value < 50)  // value is value of twitteraddress being set through the object
                {
                    _bonusBall = value;
                }
                else
                {
                    throw new Exception("The ball number must be between 1 and 49");
                }
            }
        }
        public string retailerCode { get; set; }
        public override string ToString() // This overrides the ToString() class in Ticket.
        {
            string message;
            StringBuilder sb = new StringBuilder();

            sb.Append(customer.Name);
            sb.Append(customer.Email);
            sb.Append(day);
            sb.Append(Numbers[1]);
            sb.Append(BonusBall);
            message = sb.ToString();

            return message;

        }
    }
}
