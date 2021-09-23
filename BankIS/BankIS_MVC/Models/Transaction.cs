using System;
using System.ComponentModel;

namespace BankIS.MVC.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public TransactionType Type { get; set; }

        /// <summary>
        /// Debetni operace jsou zaporne hodnoty
        /// Kreditni operace jsou kladne
        /// </summary>
        public double Value { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }
    }

    public enum TransactionType
    {
        [Description("Debetní operace (odchozí)")]
        DEBIT,

        [Description("Kreditní opearce (příchozí)")]
        CREDIT
    }
}