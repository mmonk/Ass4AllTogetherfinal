using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ass4AllTogether.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int quantity { get; set; }

        public float UnitPrice { get; set; }
    }
}