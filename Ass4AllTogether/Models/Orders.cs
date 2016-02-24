using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ass4AllTogether.Models
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public DateTime Dateordered { get; set; }

        public DateTime DateRequired { get; set; }

        public string status { get; set; }
    }
}