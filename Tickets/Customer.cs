using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    public class Customer
    {
        //public int custID { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        // constructor using an expression body, this is a shorthand version
        //public Customer(int customerId) => custID = customerId;
        public Customer()
        {
            this.Name = "";
            this.Phone = "";
            this.Email = "";
        }
        public Customer(string Name, string Phone, string Email) {
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
        }

        public override string ToString() // This overrides the standard String ToString() class.
        {
            return String.Format("Name: {0} \nPhone Number: {1} \n", Name, Phone);
        }
    }
}
