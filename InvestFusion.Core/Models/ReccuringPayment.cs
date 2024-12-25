using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestFusion.Core.Models
{
    public class ReccuringPayment
    {
        public int Id { get; set; }
        public DateOnly PaymentDate { get; set; }
        public bool Paid { get; set; }
    }
}
