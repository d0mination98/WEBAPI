using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesApi.Models
{
    public abstract class ModelBase
    {
        public ModelBase()
        {
            CreatedDate = DateTime.Now;
            CreatedBy = "Dom";
        }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}