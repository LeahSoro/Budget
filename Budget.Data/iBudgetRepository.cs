using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.Data
{
    public class iBudgetRepository
    {
        private string _connectionstring;
        public iBudgetRepository(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        public IEnumerable<Expense> GetAllExpenses()
        {
            using (var context = new BudgetDataContext(_connectionstring))
            {
                var loadOptions = new DataLoadOptions();
                loadOptions.LoadWith<Expense>(e => e.Store);
                loadOptions.LoadWith<Expense>(e => e.Method);
                context.LoadOptions = loadOptions;
                return context.Expenses.ToList();
            }
        }
        public IEnumerable<Expense> SortExpense()
        {
            IEnumerable<Expense> expense = GetAllExpenses();
            return expense.OrderBy(e => e.Date);
        }
        public IEnumerable<Expense> FilterBystore(string term)
        {

            IEnumerable<Expense> expense = GetAllExpenses();
            return expense.Where(e => e.Store.Name == term);

        }
        public IEnumerable<Expense> FilterByCategory(string term)
        {
            IEnumerable<Expense> expenses = GetAllExpenses();
            return expenses.Where(e => e.Type == term);
        }
        //public IEnumerable<Expense> FilterByAmount(int amount)
        //{
        //    IEnumerable<Expense>

        //}
        public IEnumerable<Store> GetAllStores()
        {
            using (var context = new BudgetDataContext(_connectionstring))
            {
                return context.Stores.ToList();
            }
        }
        public IEnumerable<Method> GetAllMethods()
        {
            using (var context = new BudgetDataContext(_connectionstring))
            {
                return context.Methods.ToList();
            }
        }
        public void AddExpenes(Expense expense)
        {
            using (var context = new BudgetDataContext(_connectionstring))
            {
                context.Expenses.InsertOnSubmit(expense);
                context.SubmitChanges();
            }
        }
        public void AddStore(Store store)
        {
            using (var context = new BudgetDataContext(_connectionstring))
            {
                context.Stores.InsertOnSubmit(store);
                context.SubmitChanges();
            }
        }
        public void AddMethod(Method method)
        {
            using (var context = new BudgetDataContext(_connectionstring))
            {
                context.Methods.InsertOnSubmit(method);
                context.SubmitChanges();
            }
        }
    }
}

