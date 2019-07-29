using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoWebApp.Models
{
    [Table("Transaction")]
    public class TransactionsModels
    {
        [Key]
        public int TransactionID { get; set; }
        public int CustomerID { get; set; }
        public System.DateTime Date { get; set; }
        public string Reason { get; set; }
        public string Treatment { get; set; }
        public Nullable<System.DateTime> FollowUpDate { get; set; }

        public virtual CustomerModel Customers { get; set; }
    }
}