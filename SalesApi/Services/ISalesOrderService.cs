using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SalesApi.Models;

namespace SalesApi.Services
{
    public interface ISalesOrderService
    {
        int CreateSale(SoHead soHead);
        SoHead GetSalesOrder(int id);

        List<SoHead> GetSalesOrder();
    }
}