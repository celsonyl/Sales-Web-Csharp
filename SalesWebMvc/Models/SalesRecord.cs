using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Double Amount { get; set; }
        public SalesStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double amount, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Seller = seller;
        }
    }
}
