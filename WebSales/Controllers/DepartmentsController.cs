using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSales.Models;
namespace WebSales.Controllers
{
    public class DepartmentsController : Controller
    {

        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Nome = "Eletronics" });
            list.Add(new Department { Id = 2, Nome = "Eletronics 2 " });

            return View(list);
        }
    }
}
