namespace CLASSEM_MVC_PRO.Models.DTOs.TransactionDTOs
{
    public class TransactionDTOs
    {
        public DateTime Created { get; set; }
        public string ProductId { get; set; }
        public string ReferenceNo { get; set; }
        public string AdminId { get; set; }
        public string CustomerId { get; set; }
        public int Quantity { get; set; }
         public double AmountPaid { get; set; }
        public double SellingPrice { get; set; }
        public double TotalAmount { get; set; }
    }
}