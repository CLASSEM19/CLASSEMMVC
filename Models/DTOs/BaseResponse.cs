namespace CLASSEM_MVC_PRO.Models.DTOs
{
    public class BaseResponse
    {
        public bool Status { get; set; }    
        public string Message { get; set; }
        public string ValidationErrors { get; set; }
    }
}