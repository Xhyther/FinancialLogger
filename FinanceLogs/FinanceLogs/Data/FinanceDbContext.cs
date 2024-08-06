using Microsoft.EntityFrameworkCore;
using FinanceLogs.Models;

namespace FinanceLogs.Data
{
    public class FinanceDbContext : DbContext
    {
        public FinanceDbContext(DbContextOptions<FinanceDbContext> options) : 
            base(options) 
        { 
        }

        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Wants> Wants { get; set; }
        public DbSet<History> History { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Financial Summary as a keyless entity
            modelBuilder.Entity<FinancialSummary>().HasNoKey();
        }
    }
}
