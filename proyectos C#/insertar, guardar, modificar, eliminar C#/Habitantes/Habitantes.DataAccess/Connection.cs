﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Habitantes.DataAccess
{
    public class Connection
    {
        protected string cadena = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
    }
}
