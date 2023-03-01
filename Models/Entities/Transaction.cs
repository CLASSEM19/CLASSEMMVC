using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CLASSEM_MVC_PRO.Models.Entities
{
    public class Transaction
    {
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int Quantity { get; set; }
        public string ProductId { get; set; }
        [Key]
        public string ReferenceNo { get; set; }
        public double AmountPaid { get; set; }
        public double SellingPrice { get; set; }
        public double TotalAmount { get; set; }
        public DateTime Created { get; set; }
    }
}