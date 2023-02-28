using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLASSEM_MVC_PRO.Models.DTOs.CustomerDTOs
{
    public class UpdateCustomerBalanceRequestModel
    {
        public string UserId{get;set;}
        public double Balance{get;set;}
    }
}