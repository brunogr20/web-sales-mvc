﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSales.Services.Exceptions
{
    public class DbConcurrentcyException : ApplicationException
    {

        public DbConcurrentcyException(string mensage): base(mensage)
        {

        }

            
    }
}