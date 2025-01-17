﻿namespace FinanceLogs.Models
{
    public class History
    {
        public int Id { get; set; }
        public List<Income> Incomes { get; set; } = new List<Income>();
        public List<Expense> Expenses { get; set; } = new List<Expense>();
    }
}
