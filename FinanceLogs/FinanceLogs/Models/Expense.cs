﻿namespace FinanceLogs.Models
{
    public class Expense
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }

    }
}
