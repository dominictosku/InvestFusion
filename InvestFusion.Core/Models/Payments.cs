using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestFusion.Core.Models
{
    public class Payments
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsReccuring { get; set; }
        public decimal Price { get; set; }
        public List<ReccuringPayment>? ReccuringPayment { get; set; }
    }
}
