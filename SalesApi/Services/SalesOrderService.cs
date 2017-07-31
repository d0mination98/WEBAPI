using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SalesApi.Models;

namespace SalesApi.Services
{
    public class SalesOrderService : ISalesOrderService
    {
        private ISalesOrderContext _context{get;set;}

        public SalesOrderService(ISalesOrderContext context)
        {
            _context = context;
        }


        public SoHead GetSalesOrder(int id)
        {
            return _context.SoHeads.Include("Customer").SingleOrDefault(x=>x.SoHeadId == id);        
        }

        public List<SoHead> GetSalesOrder()
        {
            return _context.SoHeads.Include("Customer").ToList();
        }

        public int CreateSale(SoHead soHead)
        {
            _context.SoHeads.Add(soHead);
           return _context.SaveChanges();

        }
    }
}