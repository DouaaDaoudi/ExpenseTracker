﻿using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; } 
        public DateTime Date { get; set; } 
        public string Category { get; set; } = string.Empty;
        public decimal Amount { get; set; } 

        public string? Notes { get; set; } 
    }
}
