using InvestFusion.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestFusion.Core.Models
{
    public class Bank : IDatabaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
