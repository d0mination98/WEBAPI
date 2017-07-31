using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesApi.Models
{
    public class SoItem: ModelBase
    {
        public int SoItemId { get; set; }
        public short SequenceNumber { get; set;}
        public string ModelNumber { get; set; }

        public decimal ItemTotal { get; set; }

    }
}