﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public partial class ProductClass
    {
        public int ObjId { get; set; }
        public int? TheProduct { get; set; }
        public int? TheProductType { get; set; }

        public virtual Product TheProductNavigation { get; set; }
        public virtual ProductType TheProductTypeNavigation { get; set; }
    }
}
