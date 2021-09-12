﻿using System;
using System.Collections.Generic;

namespace WebSales.Models.ViewModels
{
    public class SellerFormViewModel
    {
       public Seller Seller { get; set; }
       public ICollection<Department> Departments { get; set; }
    }
}