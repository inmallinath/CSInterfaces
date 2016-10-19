﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInterfaces.Library
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime StartDate { get; set; }
        public int Rating { get; set; }

        public override string ToString()
        {
            return FirstName + " \n" + LastName + "\n" + EmailAddress + "\n" + StartDate.ToShortDateString() + "\n" + Rating + "\r\n";
        }
    }
}
