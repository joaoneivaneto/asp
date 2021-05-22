using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethenyPieShop2.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set;  }
        public int PieId { get; set;  }
        public int Amout { get; set;  }
        public decimal Price { get; set; }
        public Pie Pie { get; set; }
        public Order Order { get; set; }
    }
}
