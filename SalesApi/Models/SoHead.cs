using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesApi.Models
{
    public class SoHead: ModelBase
    {
        public int SoHeadId { get; set; }
        public decimal SalesOrderTotal { get; set; }

        public Customer Customer { get; set; }
        public virtual List<SoItem> SoItems { get; set; }

    }
}