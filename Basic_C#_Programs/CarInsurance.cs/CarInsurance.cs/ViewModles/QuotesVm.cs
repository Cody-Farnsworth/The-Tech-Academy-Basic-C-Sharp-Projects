using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.cs.ViewModles
{
    public class QuotesVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public decimal Quote { get; set; }
    }
}