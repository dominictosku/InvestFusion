using InvestFusion.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestFusion.Core.Models
{
    public class AccountTransactions : IDatabaseEntity
    {
        public int Id { get; set; }
        public DateOnly MonthDate {  get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public int BankId { get; set; }
    }
}
