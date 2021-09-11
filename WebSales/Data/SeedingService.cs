using System;
using System.Collections.Generic;
using System.Linq;
using WebSales.Models;
using WebSales.Models.Enums;

namespace WebSales.Data
{
    public class SeedingService
    {
        private WebSalesContext _context;

        public SeedingService(WebSalesContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.SalesRecord.Any() || _context.Seller.Any())
            {
                return;
            }

            string[] dp = new string[] { "Eletrônicos", "Cosméticos", "Perfumaria", "Bomboniere", "Textil", "Cereais" };
            string[] fn = new string[] { "Raphaela", "Maria", "Gustavo", "Gabriel", "Miguel", "Nícolas", "Bruno", "Juliana" };
            string[] ln = new string[] { "Silva", "Reis", "Cruz", "Rocha", "Mangueira", "Mendes", "Sousa", "Gomes" };

            Random random = new Random();
            List<Department> departments = new List<Department>();
            List<Seller> sellers = new List<Seller>();
            List<SalesRecord> salesRecords = new List<SalesRecord>();


            int totalDP = dp.Length;
            int totalFN = fn.Length;
            int totalLN = ln.Count();

            for (var i = 0; i < totalDP; i++)
            {
                departments.Add(new Department((i+1), dp[i]));
            }

            for (int i = 0; i < 10; i++)
            {
                string name = fn[random.Next(0, totalDP - 1)] + " " + ln[random.Next(0, totalDP - 1)];
                string email = name.Replace(" ", "").ToLower() + "@gmail.com";
                DateTime birthDate = new DateTime(random.Next(1980, 2005), random.Next(1, 12), random.Next(1, 30));
                double baseSalary = random.Next(1100, 10000);
                int ran = random.Next(0,totalDP - 1);
                sellers.Add(new Seller((i + 1), name, email, birthDate, baseSalary, departments.Find(d => d.Id == ran)));
            }

            string[] stutusEnum = new string[] { "Pending", "Billed", "Canceled" };

            for (int i = 0; i < 90; i++)
            {

                DateTime date = new DateTime(random.Next(2010, 2020), random.Next(1, 12), random.Next(1, 30));
                //SaleStatus status = Enum.Parse<SaleStatus>(stutusEnum[random.Next(0, 2)]);
                SaleStatus status = SaleStatus.Billed;
                double amount = random.Next(1, 100000);

                salesRecords.Add(new SalesRecord((i + 1), date, amount, status));
            }

            departments.ForEach(d=> _context.Department.Add(d));

            sellers.ForEach(s=> _context.Seller.Add(s));

            salesRecords.ForEach(sr=> _context.SalesRecord.Add(sr));

                _context.SaveChanges();

      
        }
    }
}
