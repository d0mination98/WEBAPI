using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesApi.Models
{
    public class Customer:ModelBase
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}