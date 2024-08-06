namespace FinanceLogs.Models
{
    public class FinancialSummary
    {
        public int Id { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal Balance => TotalIncome - TotalExpenses;
    }
}
