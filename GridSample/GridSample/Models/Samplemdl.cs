using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GridSample.Models
{
    public class ContactDetails
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}