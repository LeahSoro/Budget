using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Budget.Data;
using Budget.Models;

namespace Budget.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
  
        public ActionResult ViewExpenses()
        {
            var repo = new iBudgetRepository(Properties.Settings.Default.constr);
            var vm = new ExpensesViewModel();
            vm.expenses = repo.GetAllExpenses();
            return View(vm);
        }
        [HttpPost]
        public ActionResult AddExpense(Expense expense)
        {
            var repo = new iBudgetRepository(Properties.Settings.Default.constr);
            repo.AddExpenes(expense);
            return Redirect("/");
        }
        public ActionResult AddExpense()
        {
            var vm = new ExpensesViewModel();
            var repo = new iBudgetRepository(Properties.Settings.Default.constr);
            vm.stores = repo.GetAllStores();
            vm.methods = repo.GetAllMethods();
            return View(vm);
        }
        [HttpPost]
        public void AddStore(Store store)
        {
            var repo = new iBudgetRepository(Properties.Settings.Default.constr);
            repo.AddStore(store);
        }
        public ActionResult Refund(int expenseId)
        {
            var repo = new iBudgetRepository(Properties.Settings.Default.constr);
            var vm = new ExpensesViewModel();
            return View();
        }

    }

}
