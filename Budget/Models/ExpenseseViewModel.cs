using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Budget.Data;

namespace Budget.Models
{
    public class ExpensesViewModel
    {
        public IEnumerable<Store> stores { get; set; }
        public IEnumerable<Expense> expenses { get; set; }
        public IEnumerable<Method> methods { get; set; }
    }
}