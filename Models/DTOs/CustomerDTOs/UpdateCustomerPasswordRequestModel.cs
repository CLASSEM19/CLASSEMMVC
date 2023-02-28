using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLASSEM_MVC_PRO.Models.DTOs.CustomerDTOs
{
    public class UpdateCustomerPasswordRequestModel
    {
        public string UserId{get;set;} 
        public string Password{get;set;}
    }
}