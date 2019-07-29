using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoWebApp.Models
{
    [Table("Customers")]
    public class CustomerModel
    {
        [Key]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string CreditCard_Number { get; set; }
        public System.DateTime CreditCard_Expiration { get; set; }
        public string CreditCard_Code { get; set; }
    }
}