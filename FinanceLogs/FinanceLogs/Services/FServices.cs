 using FinanceLogs.Models;
using System.Linq;
using FinanceLogs.Data;

namespace FinanceLogs.Services
{
    public class FServices
    {
        public readonly FinanceDbContext _context;

        public FServices(FinanceDbContext context)
        {
            _context = context;
        }

        public void AddIncome(Income income)
        {
            _context.Incomes.Add(income);
            _context.SaveChanges();
            AddToHistory(income);
        }

        public void AddExpenses(Expense expenses)
        {
            _context.Expenses.Add(expenses);
            _context.SaveChanges();
            AddToHistory(expenses);
        }


        public void AddToHistory(Income income)
        {
            var Histories = (
            from history in _context.History
            orderby history ascending
            select history).FirstOrDefault() ?? new History { };

            Histories.Incomes.Add(income);

            if (Histories.Id == 0)
                _context.History.Add(Histories);

            _context.SaveChanges();
        }

        public void AddToHistory(Expense expense)
        {
            var Histories = (
            from history in _context.History
            orderby history ascending
            select history).FirstOrDefault() ?? new History { };

            Histories.Expenses.Add(expense);

            if (Histories.Id == 0)
                _context.History.Add(Histories);

            _context.SaveChanges();
        }

        //Instance of Financial summary
        //Since FinancialSUmmary is Keyless

        public FinancialSummary GetFinancialSummary()
        {
            var totalIncome = _context.Incomes.Sum(i => i.Price);
            var totalExpense = _context.Expenses.Sum(e => e.Price);

            return new FinancialSummary
            {
                TotalIncome = totalIncome,
                TotalExpenses = totalExpense,
          
            };
        }
    }
}
