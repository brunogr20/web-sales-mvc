using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSales.Models.Enums;


namespace WebSales.Models
{
    public class SalesRecord
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
 

        public SalesRecord()
          {

          }

        public SalesRecord(int id, DateTime date,double amount, SaleStatus status)
        {
            Id = id;
            Date = date;
            Status = status;
            Amount = amount;
        }



    }

}
