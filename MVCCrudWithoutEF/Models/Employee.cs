﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCrudWithoutEF.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string ECode { get; set; }
        public string City { get; set; }
    }
}