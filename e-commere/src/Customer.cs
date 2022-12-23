using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commere
{
    internal class Customer
    {
        string custormerId;
        string customerName;
        string customerSurname;
        string customerPhone;
        string customerEmail;
        string customerPassword;

        public string CustormerId { get => custormerId; set => custormerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerSurname { get => customerSurname; set => customerSurname = value; }
        public string CustomerPhone { get => customerPhone; set => customerPhone = value; }
        public string CustomerEmail { get => customerEmail; set => customerEmail = value; }
        public string CustomerPassword { get => customerPassword; set => customerPassword = value; }
    }
}
