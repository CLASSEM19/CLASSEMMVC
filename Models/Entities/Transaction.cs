using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CLASSEM_MVC_PRO.Models.Entities
{
    public class Transaction
    {
        [Key]
        public string TransactionId{get;set;}
    }
}