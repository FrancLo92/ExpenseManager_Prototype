using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ExpenseManager.Model
{
    public class Trip
    {
        public string destination { get; set; }
        public string from { get; set; }
        public int km { get; set; }
        public string date { get; set; }
    }
}
