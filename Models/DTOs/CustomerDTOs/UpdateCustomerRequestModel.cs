using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLASSEM_MVC_PRO.Models.DTOs.CustomerDTOs
{
    public class UpdateCustomerRequestModel
    {
        public string UserId{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string Address{get;set;}
        public double Balance{get;set;}
    }
}